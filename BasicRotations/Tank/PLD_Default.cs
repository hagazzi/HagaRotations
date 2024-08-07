﻿namespace DefaultRotations.Tank;

[Rotation("HagaPLD", CombatType.PvE, GameVersion = "7.0")]
[SourceCode(Path = "main/DefaultRotations/Tank/PLD_Default.cs")]
[Api(2)]
public sealed class HagaPLD : PaladinRotation
{
    #region Config Options
    [RotationConfig(CombatType.PvE, Name = "Use Divine Veil at 15 seconds remaining on Countdown")]
    public bool UseDivineVeilPre { get; set; } = false;

    [RotationConfig(CombatType.PvE, Name = "Use Holy Circle or Holy Spirit when out of melee range")]
    public bool UseHolyWhenAway { get; set; } = true;

    [RotationConfig(CombatType.PvE, Name = "Use Shield Bash when Low Blow is cooling down")]
    public bool UseShieldBash { get; set; } = true;
    #endregion 

    public static bool HasGoringBladeReady => Player.HasStatus(true, StatusID.GoringBladeReady);
    public static bool HasAtonementReady => Player.HasStatus(true, StatusID.AtonementReady);
    public static bool HasSupplicationReady => Player.HasStatus(true, StatusID.SupplicationReady);
    public static bool HasSepulchreReady => Player.HasStatus(true, StatusID.SepulchreReady);

    private const ActionID AtoPvEActionId = (ActionID)16460;
    private IBaseAction AtoPvE = new BaseAction(AtoPvEActionId);

    private const ActionID BoFPvEActionId = (ActionID)25748;
    private IBaseAction BoFPvE = new BaseAction(BoFPvEActionId);

    private const ActionID BoTPvEActionId = (ActionID)25749;
    private IBaseAction BoTPvE = new BaseAction(BoTPvEActionId);

    private const ActionID BoVPvEActionId = (ActionID)25750;
    private IBaseAction BoVPvE = new BaseAction(BoVPvEActionId);

    private const ActionID ConfiPvEActionId = (ActionID)16459;
    private IBaseAction ConfiPvE = new BaseAction(ConfiPvEActionId);

    #region Countdown Logic
    protected override IAction? CountDownAction(float remainTime)
    {
        if (remainTime < HolySpiritPvE.Info.CastTime + CountDownAhead
            && HolySpiritPvE.CanUse(out var act)) return act;

        if (remainTime < 15 && UseDivineVeilPre
            && DivineVeilPvE.CanUse(out act)) return act;

        return base.CountDownAction(remainTime);
    }
    #endregion

    #region oGCD Logic
    protected override bool EmergencyAbility(IAction nextGCD, out IAction? act)
    {
        if (InCombat)
        {
            if (HasTankStance && OathGauge == 100 && UseOath(out act)) return true;
        }

        if (Player.HasStatus(true, StatusID.Cover) && HallowedGroundPvE.CanUse(out act)) return true;

        if ((Player.HasStatus(true, StatusID.Rampart) || Player.HasStatus(true, StatusID.Sentinel)) && InterventionPvE.CanUse(out act) &&
            InterventionPvE.Target.Target?.GetHealthRatio() < 0.6) return true;

        if (CoverPvE.CanUse(out act) && CoverPvE.Target.Target?.DistanceToPlayer() < 10 && CoverPvE.Target.Target?.GetHealthRatio() < 0.3) return true;

        return base.EmergencyAbility(nextGCD, out act);
    }

    protected override bool AttackAbility(IAction nextGCD, out IAction? act)
    {
        act = null;

        if (InCombat)
        {
            if (UseBurstMedicine(out act)) return true;
            if (IsBurst && !CombatElapsedLess(5) && FightOrFlightPvE.CanUse(out act)) return true;
        }
        if (CombatElapsedLess(8)) return false;

        if (CircleOfScornPvE.CanUse(out act, skipAoeCheck: true)) return true;
        if (SpiritsWithinPvE.CanUse(out act, skipAoeCheck: true)) return true;

        //if (Player.WillStatusEndGCD(6, 0, true, StatusID.FightOrFlight)
        //    && RequiescatPvE.CanUse(out act, skipAoeCheck: true)) return true;
        if (Player.HasStatus(true, StatusID.FightOrFlight) && RequiescatPvE.CanUse(out act, skipAoeCheck: true)) return true;

        if (!IsMoving && IntervenePvE.CanUse(out act, skipAoeCheck: true, usedUp: HasFightOrFlight)) return true;

        return base.AttackAbility(nextGCD, out act);
    }

    [RotationDesc(ActionID.ReprisalPvE, ActionID.DivineVeilPvE)]
    protected override bool DefenseAreaAbility(IAction nextGCD, out IAction? act)
    {

        //if (DivineVeilPvE.CanUse(out act)) return true;

        //if (PassageOfArmsPvE.CanUse(out act)) return true;
        return base.DefenseAreaAbility(nextGCD, out act);
    }

    [RotationDesc(ActionID.SentinelPvE, ActionID.RampartPvE, ActionID.BulwarkPvE, ActionID.SheltronPvE, ActionID.ReprisalPvE)]
    protected override bool DefenseSingleAbility(IAction nextGCD, out IAction? act)
    {

        // If the player has the Hallowed Ground status, don't use any abilities.
        if (!Player.HasStatus(true, StatusID.HallowedGround))
        {
            // If Bulwark can be used and there are more than 2 hostiles in range, use it and return true.
            if (BulwarkPvE.CanUse(out act, true) && NumberOfHostilesInRange > 2) return true;

            // If Oath can be used, use it and return true.
            if (UseOath(out act, true)) return true;

            // If Rampart is not cooling down or has been cooling down for more than 60 seconds, and Sentinel can be used, use Sentinel and return true.
            if ((!RampartPvE.Cooldown.IsCoolingDown || RampartPvE.Cooldown.ElapsedAfter(60)) && SentinelPvE.CanUse(out act)) return true;

            // If Sentinel is at an enough level and is cooling down for more than 60 seconds, or if Sentinel is not at an enough level, and Rampart can be used, use Rampart and return true.
            if ((SentinelPvE.EnoughLevel && SentinelPvE.Cooldown.IsCoolingDown && SentinelPvE.Cooldown.ElapsedAfter(60) || !SentinelPvE.EnoughLevel) && RampartPvE.CanUse(out act)) return true;

            // If Reprisal can be used, use it and return true.
            if (ReprisalPvE.CanUse(out act, skipAoeCheck: true, skipStatusProvideCheck: true)) return true;

        }

        return base.DefenseSingleAbility(nextGCD, out act);
    }
    #endregion

    #region GCD Logic
    protected override bool GeneralGCD(out IAction? act)
    {
        ConfiteorPvE.Setting.StatusProvide = [];


        if (Player.HasStatus(true, StatusID.Requiescat))
        {
            if (Player.Level >= 100)
            {
                if (BladeOfHonorPvE.CanUse(out act, skipAoeCheck: true)) return true;
            }
            if ((Player.Level >= 90) && (Player.StatusStack(true, StatusID.Requiescat) < 4))
            {
                //if (BladeOfValorPvE.CanUse(out act, skipAoeCheck: true)) return true;
                //if (BladeOfTruthPvE.CanUse(out act, skipAoeCheck: true)) return true;
                //if (BladeOfFaithPvE.CanUse(out act, skipAoeCheck: true)) return true;
                if (ConfiPvE.CanUse(out act, skipAoeCheck: true)) return true;
            }
            if ((Player.Level >= 80) && (Player.StatusStack(true, StatusID.Requiescat) > 3))
            {
                if (ConfiPvE.CanUse(out act, skipAoeCheck: true)) return true;
            }
                
            if (HolyCirclePvE.CanUse(out act)) return true;
            if (HolySpiritPvE.CanUse(out act)) return true;
        }

        //if (Player.HasStatus(true, StatusID.Requiescat))
        //{
        //    if (ConfiteorPvE.CanUse(out act, skipAoeCheck: true))
        //    {
        //        if (Player.HasStatus(true, StatusID.ConfiteorReady)) return true;
        //        if (ConfiteorPvE.ID != ConfiteorPvE.AdjustedID) return true;
        //    }
        //if (BladeOfHonorPvE.CanUse(out act, skipAoeCheck: true, skipStatusProvideCheck: true, skipComboCheck: true, skipCastingCheck: true, usedUp: true)) return true;
        //if (BladeOfValorPvE.CanUse(out act, skipAoeCheck: true, skipStatusProvideCheck: true, skipComboCheck: true, skipCastingCheck: true, usedUp: true)) return true;
        //if (BladeOfTruthPvE.CanUse(out act, skipAoeCheck: true, skipStatusProvideCheck: true, skipComboCheck: true, skipCastingCheck: true, usedUp: true)) return true;
        //if (BladeOfFaithPvE.CanUse(out act, skipAoeCheck: true, skipStatusProvideCheck: true, skipComboCheck: true, skipCastingCheck: true, usedUp: true)) return true;
        //if (ConfiteorPvE.CanUse(out act, skipAoeCheck: true)) return true;
        //if (HolyCirclePvE.CanUse(out act)) return true;
        //if (HolySpiritPvE.CanUse(out act)) return true;
        //}

        //AOE
        if (HasDivineMight && HolyCirclePvE.CanUse(out act)) return true;
        if (!Player.HasStatus(true, StatusID.Requiescat))
        {
            if (ProminencePvE.CanUse(out act)) return true;
            if (TotalEclipsePvE.CanUse(out act)) return true;
        }


        //Single
        if (!CombatElapsedLess(8) && HasGoringBladeReady && GoringBladePvE.CanUse(out act)) return true; // Dot
        if (!FightOrFlightPvE.Cooldown.WillHaveOneChargeGCD(2))
        {
            if (!FightOrFlightPvE.Cooldown.WillHaveOneChargeGCD(6) &&
                HasDivineMight && !Player.HasStatus(true, StatusID.Requiescat) && HolySpiritPvE.CanUse(out act)) return true;
            if (RageOfHalonePvE.CanUse(out act)) return true;
            if (AtonementPvE.CanUse(out act)) return true;
        }
        //123
        if (UseShieldBash && ShieldBashPvE.CanUse(out act)) return true;

        if (HasSepulchreReady && SepulchrePvE.CanUse(out act)) return true;
        if (HasSupplicationReady && SupplicationPvE.CanUse(out act)) return true;
        if (HasAtonementReady && AtoPvE.CanUse(out act, skipStatusProvideCheck: true, skipComboCheck: true, skipCastingCheck: true, skipAoeCheck: true, usedUp: true)) return true;

        if (!Player.HasStatus(true, StatusID.Requiescat))
        {
            if (RageOfHalonePvE.CanUse(out act)) return true;
            if (RiotBladePvE.CanUse(out act)) return true;
            if (FastBladePvE.CanUse(out act)) return true;
        }


        //Range
        if (UseHolyWhenAway)
        {
            if (HolyCirclePvE.CanUse(out act)) return true;
            if (HolySpiritPvE.CanUse(out act)) return true;
        }
        if (ShieldLobPvE.CanUse(out act)) return true;

        return base.GeneralGCD(out act);
    }
    #endregion

    #region Extra Methods
    private bool UseOath(out IAction act, bool onLast = false)
    {
        if (SheltronPvE.CanUse(out act, usedUp: onLast)) return true;
        if (InterventionPvE.CanUse(out act, usedUp: onLast)) return true;

        return false;
    }

    public override void DisplayStatus()
    {
        ImGui.Text("-----PLD");
        ImGui.Text("Level: "+Player.Level.ToString());
        ImGui.Text("Confi Enough Level: " + ConfiteorPvE.EnoughLevel.ToString());
        ImGui.Text("BoT Enough Level: " + BladeOfTruthPvE.EnoughLevel.ToString());
        ImGui.Text("Requiescat Stacks: " + Player.StatusStack(true, StatusID.Requiescat).ToString());
        base.DisplayStatus();
    }
    #endregion
}