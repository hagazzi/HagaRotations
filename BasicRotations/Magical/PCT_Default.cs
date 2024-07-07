namespace DefaultRotations.Magical;

[Rotation("Default", CombatType.PvE, GameVersion = "7.0")]
[SourceCode(Path = "main/DefaultRotations/Magical/PCT_Default.cs")]
[Api(2)]
public sealed class PCT_Default : PictomancerRotation
{

    private const ActionID WMPVEActionID = (ActionID)34665;
    private IBaseAction WMPvE = new BaseAction(WMPVEActionID);

    private const ActionID FiRPVEActionID = (ActionID)34650;
    private IBaseAction FiRPvE = new BaseAction(FiRPVEActionID);

    private const ActionID FiRIIPVEActionID = (ActionID)34656;
    private IBaseAction FiRIIPvE = new BaseAction(FiRIIPVEActionID);

    private const ActionID PomMPVEActionID = (ActionID)34670;
    private IBaseAction PomMPvE = new BaseAction(PomMPVEActionID);

    private const ActionID WingMPVEActionID = (ActionID)34671;
    private IBaseAction WingMPvE = new BaseAction(WingMPVEActionID);


    public override MedicineType MedicineType => MedicineType.Intelligence;
    #region Countdown logic
    // Defines logic for actions to take during the countdown before combat starts.
    protected override IAction? CountDownAction(float remainTime)
    {
        return base.CountDownAction(remainTime);
    }
    #endregion

    #region Emergency Logic
    // Determines emergency actions to take based on the next planned GCD action.
    protected override bool EmergencyAbility(IAction nextGCD, out IAction? act)
    {
        act = null;

        return base.EmergencyAbility(nextGCD, out act);
    }
    #endregion

    #region oGCD Logic
    protected override bool AttackAbility(IAction nextGCD, out IAction? act)
    {
        //LivingMusePve.AdjusteId == 34670 rdy to cast Pom Muse 34671 Winged Muse  , 35347 not ready to cast anything
        //SteelMusePve.AdjusteId == 34674 rdy to cast Striking Muse  , 35348 not ready to cast anything
        //ScenicMusePve.AdjusteId ==  34675, 35349 not ready to cast anything

        bool PomMuseReady = (LivingMusePvE.AdjustedID == 34670);
        bool WingedMusefReady = (LivingMusePvE.AdjustedID == 34671);

        if (!Player.HasStatus(true, StatusID.SubtractivePalette) && (PaletteGauge >= 50) && SubtractivePalettePvE.CanUse(out act)) return true;
        if (MogOfTheAgesPvE.CanUse(out act, skipStatusProvideCheck: true, skipComboCheck: true, skipCastingCheck: true, skipAoeCheck: true, usedUp: true)) return true;
        //act = null;
        //if (WeaponMotifDrawn && SteelMusePvE.CanUse(out act)) return true;
        //if (WeaponMotifDrawn && PomMusePvE.CanUse(out act, skipCastingCheck: true, skipAoeCheck: true)) return true;
        if (CreatureMotifDrawn && PomMuseReady && PomMPvE.CanUse(out act, skipStatusProvideCheck: true, skipComboCheck: true, skipCastingCheck: true, skipAoeCheck: true, usedUp: true)) return true;
        if (CreatureMotifDrawn && WingedMusefReady && WingMPvE.CanUse(out act, skipStatusProvideCheck: true, skipComboCheck: true, skipCastingCheck: true, skipAoeCheck: true, usedUp: true)) return true;
        //if (CreatureMotifDrawn && LivingMusePvE.CanUse(out act)) return true;
        if (WeaponMotifDrawn && StrikingMusePvE.CanUse(out act, skipStatusProvideCheck: true, skipComboCheck: true, skipCastingCheck: true, skipAoeCheck: true, usedUp: true)) return true;
        if (LandscapeMotifDrawn && StarryMusePvE.CanUse(out act, skipStatusProvideCheck: true, skipComboCheck: true, skipCastingCheck: true, skipAoeCheck: true, usedUp: true)) return true;


        return base.AttackAbility(nextGCD, out act);
    }

    protected override bool MoveForwardAbility(IAction nextGCD, out IAction? act)
    {
        act = null;


        return base.MoveForwardAbility(nextGCD, out act);
    }
    #endregion

    #region GCD Logic
    protected override bool MoveForwardGCD(out IAction? act)
    {
        act = null;

        return base.MoveForwardGCD(out act);
    }

    protected override bool GeneralGCD(out IAction? act)
    {

        bool HammerMotifReady = (WeaponMotifPvE.AdjustedID == 34668);
        bool WingMotifReady = (CreatureMotifPvE.AdjustedID == 34665);
        bool PomMotifReady = (CreatureMotifPvE.AdjustedID == 34664);
        //WeaponMotifPvE.AdjustedID == 34668 => rdy to cast HammerMotif, 34690 not ready to cast anything
        //CreatureMotifPve.AdjustedID == 34665 => rdy to cast WingMotif / 34664 =>rdy to cast PomMotif , 34689 not ready to cast anything
        //LandscapeMotifPvE .AdjustedID == 34691 => rdy to cast StarrySkyMotif , 34669 not ready to cast anything

        if (Player.HasStatus(true, StatusID.HammerTime) && HammerStampPvE.CanUse(out act, skipCastingCheck: true, skipAoeCheck: true)) return true;

        //
        //Hammer Stamp
        //
        //if (!CreatureMotifDrawn && WingMotifReady && PomMotifPvE.CanUse(out act)) return true;
        if (!CreatureMotifDrawn && WingMotifReady && WingMotifPvE.CanUse(out act)) return true;
        if (!CreatureMotifDrawn && PomMotifReady && PomMotifPvE.CanUse(out act)) return true;
        if (!WeaponMotifDrawn && HammerMotifReady &&  HammerMotifPvE.CanUse(out act)) return true;
        //if (!CreatureMotifDrawn && WingMotifPvE.CanUse(out act)) return true;
        //if (!WeaponMotifDrawn && WeaponMotifPvE.CanUse(out act)) return true;
        //if (!WeaponMotifDrawn && HammerStampPvE.CanUse(out act)) return true;
        //if (!LandscapeMotifDrawn && LandscapeMotifPvE.CanUse(out act)) return true;
        //act = null;

        if(Player.HasStatus(true, StatusID.SubtractivePalette))
        {
            //AOE
            if (ThunderIiInMagentaPvE.CanUse(out act, skipCastingCheck: true)) return true;
            if (StoneIiInYellowPvE.CanUse(out act, skipCastingCheck: true)) return true;
            if (BlizzardIiInCyanPvE.CanUse(out act, skipCastingCheck: true)) return true;

            //123
            if (ThunderInMagentaPvE.CanUse(out act, skipCastingCheck: true)) return true;
            if (StoneInYellowPvE.CanUse(out act, skipCastingCheck: true)) return true;
            if (BlizzardInCyanPvE.CanUse(out act, skipCastingCheck: true)) return true;

        }
        else
        { 
            if (HolyInWhitePvE.CanUse(out act, skipCastingCheck: true, skipAoeCheck: true)) return true;
            //AOE
            if (WaterIiInBluePvE.CanUse(out act, skipCastingCheck: true)) return true;
            if (AeroIiInGreenPvE.CanUse(out act, skipCastingCheck: true)) return true;
            if (FireIiInRedPvE.CanUse(out act, skipCastingCheck: true)) return true;

            //123
            if (WaterInBluePvE.CanUse(out act, skipCastingCheck: true)) return true;
            if (AeroInGreenPvE.CanUse(out act, skipCastingCheck: true)) return true;
            if (FireInRedPvE.CanUse(out act, skipCastingCheck: true)) return true;
        }

        //if (FiRPvE.CanUse(out act)) return true;


        return base.GeneralGCD(out act);
    }

    private bool AttackGCD(out IAction? act, bool burst)
    {
        act = null;

        return false;
    }
    #endregion

    #region Extra Methods
    // Extra private helper methods for determining the usability of specific abilities under certain conditions.
    // These methods simplify the main logic by encapsulating specific checks related to abilities' cooldowns and prerequisites.
    //private bool CanUseExamplePvE(out IAction? act)
    //{

    //}

    public override void DisplayStatus()
    {
        //if (_ninActionAim != null)
        //{
        //    ImGui.Text(_ninActionAim.ToString() + _ninActionAim.AdjustedID.ToString());
        //}
        //ImGui.Text("LordoC " + LordOfCrownsPvE.AdjustedID.ToString());
        //ImGui.Text("LadyoC " + LadyOfCrownsPvE.AdjustedID.ToString());
        //ImGui.Text("MinorArcana " + MinorArcanaPvE.AdjustedID.ToString());
        //ImGui.Text("AstralD " + AstralDrawPvE.AdjustedID.ToString());
        //ImGui.Text("UmbralD " + UmbralDrawPvE.AdjustedID.ToString());
        //ImGui.Text("Play1 " + PlayIPvE.AdjustedID.ToString());
        //ImGui.Text("Play2 " + PlayIiPvE.AdjustedID.ToString());
        //ImGui.Text("Play3 " + PlayIiiPvE.AdjustedID.ToString());
        //ImGui.Text("HStamp " + HammerStampPvE.IsInCooldown.ToString());
        //ImGui.Text("StrikingMuse cd " + StrikingMusePvE.IsInCooldown.ToString());
        //ImGui.Text("StrikingMuse enabled " + StrikingMusePvE.IsEnabled.ToString());
        //ImGui.Text("SteelMuse cd " + SteelMusePvE.IsInCooldown.ToString());
        //ImGui.Text("SteelMuse enabled " + SteelMusePvE.IsEnabled.ToString());
        //ImGui.Text("CreatureDrawn " + CreatureMotifDrawn.ToString());
        //ImGui.Text("WeaponDrawn " + WeaponMotifDrawn.ToString());
        //ImGui.Text("LandscrapeDrawn " + LandscapeMotifDrawn.ToString());
        //ImGui.Text("WeaponMotif " + WeaponMotifPvE.IsInCooldown.ToString());
        //ImGui.Text("HammerMotif " + HammerMotifPvE.IsInCooldown.ToString());

        //motif
        ImGui.Text("-----Motif");
        ImGui.Text("HammerMotif " + HammerMotifPvE.AdjustedID.ToString());
        ImGui.Text("WeaponMotif adjID " + WeaponMotifPvE.AdjustedID.ToString());
        ImGui.Text("-----");
        ImGui.Text("WingMotif " + WingMotifPvE.AdjustedID.ToString());
        ImGui.Text("CreatureMotif adjID " + CreatureMotifPvE.AdjustedID.ToString());
        ImGui.Text("-----");
        ImGui.Text("StarrySkyMotif " + StarrySkyMotifPvE.AdjustedID.ToString());
        ImGui.Text("LandscapeMotif adjID " + LandscapeMotifPvE.AdjustedID.ToString());

        //muse
        ImGui.Text("-----Muse");
        ImGui.Text("PomMuse " + PomMusePvE.AdjustedID.ToString());
        ImGui.Text("LivingMuse adjID " + LivingMusePvE.AdjustedID.ToString());
        ImGui.Text("-----");
        ImGui.Text("StrikingMuse " + StrikingMusePvE.AdjustedID.ToString());
        ImGui.Text("SteelMuse adjID " + SteelMusePvE.AdjustedID.ToString());
        ImGui.Text("-----");
        ImGui.Text("StarryMuse " + StarryMusePvE.AdjustedID.ToString());
        ImGui.Text("ScenicMuse adjID " + ScenicMusePvE.AdjustedID.ToString());


        //ImGui.Text("HammerMotif " + HammerMotifPvE.IsInCooldown.ToString());
        base.DisplayStatus();
    }
    #endregion
}