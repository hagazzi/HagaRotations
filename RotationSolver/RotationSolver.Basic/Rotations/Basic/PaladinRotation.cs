﻿namespace RotationSolver.Basic.Rotations.Basic;

partial class PaladinRotation
{
    /// <inheritdoc/>
    public override MedicineType MedicineType => MedicineType.Strength;

    /// <summary>
    /// 
    /// </summary>
    public override bool CanHealSingleSpell => DataCenter.PartyMembers.Count() == 1 && base.CanHealSingleSpell;

    /// <summary>
    /// 
    /// </summary>
    public override bool CanHealAreaAbility => false;

    /// <summary>
    /// 
    /// </summary>
    public static bool HasDivineMight => !Player.WillStatusEndGCD(0, 0, true, StatusID.DivineMight);

    /// <summary>
    /// 
    /// </summary>
    public static bool HasFightOrFlight => !Player.WillStatusEndGCD(0, 0, true, StatusID.FightOrFlight);

    #region Job Gauge
    /// <summary>
    /// 
    /// </summary>
    public static byte OathGauge => JobGauge.OathGauge;
    #endregion

    static partial void ModifyAtonementPvE(ref ActionSetting setting)
    {
        setting.StatusNeed = [StatusID.SwordOath_1991];
    }

    static partial void ModifyShieldBashPvE(ref ActionSetting setting)
    {
        setting.CanTarget = o =>
        {
            if (o is not IBattleChara b) return false;

            if (b.IsBossFromIcon() || IsMoving || b.CastActionId == 0) return false;

            if (!b.IsCastInterruptible || ActionID.InterjectPvE.IsCoolingDown()) return true;
            return false;
        };
        setting.ActionCheck = () => ActionID.LowBlowPvE.IsCoolingDown();
        setting.StatusProvide = [StatusID.Stun];
    }

    static partial void ModifyShieldLobPvE(ref ActionSetting setting)
    {
        setting.SpecialType = SpecialActionType.MeleeRange;
        setting.UnlockedByQuestID = 65798;
    }

    static partial void ModifySheltronPvE(ref ActionSetting setting)
    {
        setting.UnlockedByQuestID = 66592;
    }

    private protected sealed override IBaseAction TankStance => IronWillPvE;

    static partial void ModifyRequiescatPvE(ref ActionSetting setting)
    {
        setting.CreateConfig = () => new()
        {
            TimeToKill = 0,
        };
    }

    static partial void ModifyFightOrFlightPvE(ref ActionSetting setting)
    {
        setting.CreateConfig = () => new()
        {
            TimeToKill = 0,
        };
    }

    static partial void ModifySentinelPvE(ref ActionSetting setting)
    {
        setting.StatusProvide = StatusHelper.RampartStatus;
        setting.ActionCheck = Player.IsTargetOnSelf;
    }

    static partial void ModifyBulwarkPvE(ref ActionSetting setting)
    {
        setting.StatusProvide = StatusHelper.RampartStatus;
        setting.ActionCheck = Player.IsTargetOnSelf;
    }

    static partial void ModifyCoverPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => OathGauge >= 50;
        setting.UnlockedByQuestID = 66595;
    }

    static partial void ModifyIntervenePvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => OathGauge >= 50;
    }

    static partial void ModifyHolySheltronPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => OathGauge >= 50 && Player.IsTargetOnSelf();
    }

    static partial void ModifyIntervenePvP(ref ActionSetting setting)
    {
        setting.SpecialType = SpecialActionType.MovingForward;
    }

    static partial void ModifySpiritsWithinPvE(ref ActionSetting setting)
    {
        setting.UnlockedByQuestID = 66591;
    }

    static partial void ModifyProminencePvE(ref ActionSetting setting)
    {
        setting.UnlockedByQuestID = 66593;
    }

    static partial void ModifyHallowedGroundPvE(ref ActionSetting setting)
    {
        setting.UnlockedByQuestID = 66596;
    }

    static partial void ModifyGoringBladePvE(ref ActionSetting setting)
    {
        setting.UnlockedByQuestID = 67570;
    }

    static partial void ModifyDivineVeilPvE(ref ActionSetting setting)
    {
        setting.UnlockedByQuestID = 67571;
    }

    static partial void ModifyClemencyPvE(ref ActionSetting setting)
    {
        setting.UnlockedByQuestID = 67572;
    }

    static partial void ModifyRoyalAuthorityPvE(ref ActionSetting setting)
    {
        setting.UnlockedByQuestID = 67573;
    }

    static partial void ModifyPassageOfArmsPvE(ref ActionSetting setting)
    {
        setting.UnlockedByQuestID = 68111;
    }

    /// <inheritdoc/>
    protected override bool EmergencyAbility(IAction nextGCD, out IAction? act)
    {
        if (HallowedGroundPvE.CanUse(out act)
            && Player.GetHealthRatio() <= Service.Config.HealthForDyingTanks) return true;
        return base.EmergencyAbility(nextGCD, out act);
    }

    /// <inheritdoc/>
    [RotationDesc(ActionID.IntervenePvE)]
    protected sealed override bool MoveForwardAbility(IAction nextGCD, out IAction? act)
    {
        if (IntervenePvE.CanUse(out act)) return true;
        return base.MoveForwardAbility(nextGCD, out act);
    }

    /// <inheritdoc/>
    [RotationDesc(ActionID.ClemencyPvE)]
    protected sealed override bool HealSingleGCD(out IAction? act)
    {
        if (ClemencyPvE.CanUse(out act)) return true;
        return base.HealSingleGCD(out act);
    }
}
