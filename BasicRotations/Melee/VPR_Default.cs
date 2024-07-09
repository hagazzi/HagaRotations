using Dalamud.Game.ClientState.JobGauge.Types;

namespace DefaultRotations.Melee;

[Rotation("HagaVPR", CombatType.PvE, GameVersion = "7.0")]
[SourceCode(Path = "main/DefaultRotations/Melee/VPR_Default.cs")]
[Api(2)]
public sealed class HagaVPR : ViperRotation
{
    private const ActionID DFActionId = (ActionID)34607;
    private IBaseAction DreadFPvE = new BaseAction(DFActionId);

    private const ActionID SFActionId = (ActionID)34606;
    private IBaseAction SteelFPvE = new BaseAction(SFActionId);

    private const ActionID STActionId = (ActionID)35920;
    private IBaseAction SerpentTPvE = new BaseAction(STActionId);

    private const ActionID HunterCoilActionId = (ActionID)34621;
    private IBaseAction HunterCPvE = new BaseAction(HunterCoilActionId);

    private const ActionID SwiftSkinCoilActionId = (ActionID)34622;
    private IBaseAction SwiftSkinCPvE = new BaseAction(SwiftSkinCoilActionId);



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
       act = null;

        bool DeathRattleReady = (SerpentsTailPvE.AdjustedID == 34634);
        bool LastLashReady = (SerpentsTailPvE.AdjustedID == 34635);


        if (Player.HasStatus(true, StatusID.HuntersVenom) && TwinfangBitePvE.CanUse(out act, skipStatusProvideCheck: true, skipComboCheck: true, skipCastingCheck: true, skipAoeCheck: true, usedUp: true)) return true;
        if (Player.HasStatus(true, StatusID.SwiftskinsVenom) && TwinbloodBitePvE.CanUse(out act, skipStatusProvideCheck: true, skipComboCheck: true, skipCastingCheck: true, skipAoeCheck: true, usedUp: true)) return true;
        if (Player.HasStatus(true, StatusID.FellhuntersVenom) && TwinfangPvE.CanUse(out act, skipStatusProvideCheck: true, skipComboCheck: true, skipCastingCheck: true, skipAoeCheck: true, usedUp: true)) return true;
        if (Player.HasStatus(true, StatusID.FellskinsVenom) && TwinbloodPvE.CanUse(out act, skipStatusProvideCheck: true, skipComboCheck: true, skipCastingCheck: true, skipAoeCheck: true, usedUp: true)) return true;



            //SteelFangsPvE 34606
            if (LastLashReady)
        {
            //if (SerpentTPvE.CanUse(out act, skipAoeCheck: true)) return true;
            if (LastLashPvE.CanUse(out act, skipAoeCheck: true)) return true;
        }

        if (DeathRattleReady)
        {
            //if (SerpentTPvE.CanUse(out act, skipAoeCheck: true)) return true;
            if (DeathRattlePvE.CanUse(out act, skipAoeCheck: true)) return true;
        }


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
       act = null;

        bool SteelFangsInert = (SteelFangsPvE.AdjustedID == 34606);
        bool HunterStingReady = (SteelFangsPvE.AdjustedID == 34608);
        bool FlankstingSReady = (SteelFangsPvE.AdjustedID == 34610);
        bool HindstingSReady = (SteelFangsPvE.AdjustedID == 34612);

        bool DreadFangsInert = (DreadFangsPvE.AdjustedID == 34607);
        bool SwiftskinSReady = (DreadFangsPvE.AdjustedID == 34609);
        bool FlanksbaneFReady = (DreadFangsPvE.AdjustedID == 34611);
        bool HindsbaneFReady = (DreadFangsPvE.AdjustedID == 34613);

        bool SerpentTailsInert = (SerpentsTailPvE.AdjustedID == 35920);
        bool DeathRattleReady = (SerpentsTailPvE.AdjustedID == 34634);

        bool SteelMawInert = (SteelMawPvE.AdjustedID == 34614);
        bool HunterBiteReady = (SteelMawPvE.AdjustedID == 34616);
        bool JaggedMawReady = (SteelMawPvE.AdjustedID == 34618);

        bool DreadMawInert = (SteelMawPvE.AdjustedID == 34615);
        bool SwiftskinBReady = (SteelMawPvE.AdjustedID == 34617);
        bool BloodiedMawready = (SteelMawPvE.AdjustedID == 34619);

        //HostileTarget.
        //SteelFangs 34606 inert --  34608 Hunter's Sting --  34610 Flanksting Strike -- 34612 Hindsting Strike
        //DreadFangs 34607 inert --  34609 Swiftskin's Sting -- 34611 Flanksbane Fang -- 34613 Hindsbane Fang
        //SerpentTails 35920 inert -- 34634 DeathRattleReady 

        //if (SteelFangsPvE.AdjustedID == 34608)
        //{

        //}

        //SteelMaw 34614 inert -- 34616 Hunter's Bite -- 34618 Jagged Maw
        //DreadMaw 34615 inert -- 34617 Swiftskin's Bite -- 34619 Bloodied Maw


        //aoe
        //fellhunter venom  (aoe) > Fellskin venom

        //123
        //hunter venom > swiftskin venom



        if (!Player.HasStatus(true, StatusID.HuntersVenom) 
            && !Player.HasStatus(true, StatusID.SwiftskinsVenom)
            && !Player.HasStatus(true, StatusID.FellhuntersVenom)
            && !Player.HasStatus(true, StatusID.FellskinsVenom))
        {
            if (DreadCombo == DreadCombo.HuntersDen)
            {
                if (SwiftskinsDenPvE.CanUse(out act, skipStatusProvideCheck: true, skipComboCheck: true, skipCastingCheck: true, skipAoeCheck: true, usedUp: true)) return true;
            }

            if (DreadCombo == DreadCombo.HuntersCoil)
            {
                if (SwiftskinsCoilPvE.CanUse(out act, skipStatusProvideCheck: true, skipComboCheck: true, skipCastingCheck: true, skipAoeCheck: true, usedUp: true)) return true;
            }


            if (DreadCombo == DreadCombo.PitOfDread)
            {
                if (HuntersDenPvE.CanUse(out act, skipStatusProvideCheck: true, skipComboCheck: true, skipCastingCheck: true, skipAoeCheck: true, usedUp: true)) return true;
            }


            if (DreadCombo == DreadCombo.Dreadwinder)
            {
                if (HuntersCoilPvE.CanUse(out act, skipStatusProvideCheck: true, skipComboCheck: true, skipCastingCheck: true, skipAoeCheck: true, usedUp: true)) return true;
            }

            if (DreadCombo == 0)
            {
                if (PitOfDreadPvE.CanUse(out act, skipStatusProvideCheck: true, skipComboCheck: true, skipCastingCheck: true, usedUp: true)) return true;
                if (DreadwinderPvE.CanUse(out act, skipStatusProvideCheck: true, skipComboCheck: true, skipCastingCheck: true, usedUp: true)) return true;
            }


        }
        
        if (!Player.HasStatus(true, StatusID.HuntersInstinct))
        {
            //aoe
            //if (HuntersBitePvE.CanUse(out act)) return true;
            //123
            //if (HuntersStingPvE.CanUse(out act, skipAoeCheck: true)) return true;
            //NumberOfAllHostilesInRange > 2
            if (HunterBiteReady)
            {
                if (SteelMawPvE.CanUse(out act)) return true;
            }
            

            if (HunterStingReady)
            {
                if (SteelFPvE.CanUse(out act, skipAoeCheck: true)) return true;
            }
            
        }

        if (Player.HasStatus(true, StatusID.HuntersInstinct) && !Player.HasStatus(true, StatusID.Swiftscaled))
        {
            if (HunterBiteReady)
            {
                if (DreadMawPvE.CanUse(out act)) return true;
            }
            
            if (HunterStingReady)
            {
                if (DreadFangsPvE.CanUse(out act)) return true;
            }
            
        }
        if (Player.HasStatus(true, StatusID.HuntersInstinct) && Player.HasStatus(true, StatusID.Swiftscaled) && HunterBiteReady)
        {
            if (DreadMawPvE.CanUse(out act)) return true;
        }

        if (Player.HasStatus(true, StatusID.HuntersInstinct) && Player.HasStatus(true, StatusID.Swiftscaled) && HunterStingReady)
        {

            //flank dread
            //hind steel
            if (Player.HasStatus(true, StatusID.HindsbaneVenom) || Player.HasStatus(true, StatusID.HindstungVenom))
            {
                //if (DreadMawPvE.CanUse(out act)) return true;
                if (DreadFangsPvE.CanUse(out act, skipAoeCheck: true)) return true;
            }

            if (Player.HasStatus(true, StatusID.FlanksbaneVenom) || Player.HasStatus(true, StatusID.FlankstungVenom))   
            {
                //if (SteelMawPvE.CanUse(out act)) return true;
                if (SteelFangsPvE.CanUse(out act, skipAoeCheck: true)) return true;
                
            }
        }


        if (!Player.HasStatus(true, StatusID.HindsbaneVenom) 
            && !Player.HasStatus(true, StatusID.HindstungVenom)
            && !Player.HasStatus(true, StatusID.FlankstungVenom)
            && !Player.HasStatus(true, StatusID.FlanksbaneVenom)
            && (FlankstingSReady || HindstingSReady))
        {
            //123
            if (FlankstingSReady)
            {
                if (DreadFangsPvE.CanUse(out act, skipAoeCheck: true)) return true;
            }
            if (HindstingSReady)
            {
                if (SteelFangsPvE.CanUse(out act, skipAoeCheck: true)) return true;
            }
            

        }

        //FlankstingStrikePvE grant StatusID.HindstungVenom
        //FlanksbaneFangPvE  grant StatusID.HindsbaneVenom

        //venom
        //hindstung venom > hindsting strike > steelfang | HindstingSReady
        //hindsbane venom > hindsbane fang > dreadfang |  HindstingSReady
        //flankbane venom > Flanksbane Fang > dreadfang | FlankstingSReady
        //flankstung venom > flanksting strike > steelfang | FlankstingSReady


        //grimhunter venom
        //grimskin venom
        //aoe
        if (!Player.HasStatus(true, StatusID.GrimskinsVenom) && !Player.HasStatus(true, StatusID.GrimhuntersVenom) && (JaggedMawReady || BloodiedMawready))
        {
            if (SteelMawPvE.CanUse(out act)) return true;
        }

        if (Player.HasStatus(true, StatusID.GrimhuntersVenom) && (JaggedMawReady || BloodiedMawready))
        {
            if (SteelMawPvE.CanUse(out act)) return true;
        }

        if (Player.HasStatus(true, StatusID.GrimskinsVenom) && (JaggedMawReady || BloodiedMawready))
        {
            if (DreadMawPvE.CanUse(out act)) return true;
        }


        //123
        if (Player.HasStatus(true, StatusID.HindsbaneVenom) && (FlankstingSReady || HindstingSReady))
        {
            //123
            if (DreadFangsPvE.CanUse(out act, skipAoeCheck: true)) return true;
        }

        if (Player.HasStatus(true, StatusID.HindstungVenom) && (FlankstingSReady || HindstingSReady))
        {
            //123
            if (SteelFangsPvE.CanUse(out act, skipAoeCheck: true)) return true;
        }

        if (Player.HasStatus(true, StatusID.FlanksbaneVenom) && (FlankstingSReady || HindstingSReady))
        {
            //123
            if (DreadFangsPvE.CanUse(out act, skipAoeCheck: true)) return true;
        }

        if (Player.HasStatus(true, StatusID.FlankstungVenom) && (FlankstingSReady || HindstingSReady))
        {
            //123
            if (SteelFangsPvE.CanUse(out act, skipAoeCheck: true)) return true;
        }



        if ((!HostileTarget?.HasStatus(true, StatusID.NoxiousGnash) ?? false))
        {
            //aoe
            //if (SteelMawInert && DreadMawInert)
            //{
                if (DreadMawPvE.CanUse(out act)) return true;
            //}
            //123
            //if (SteelFangsInert && DreadFangsInert)
            //{
                if (DreadFangsPvE.CanUse(out act, skipAoeCheck: true)) return true;
            //}

        }

        if ((HostileTarget?.HasStatus(true, StatusID.NoxiousGnash) ?? false))
        {
            //aoe
            //if (SteelMawInert && DreadMawInert)
            //{
                if (SteelMawPvE.CanUse(out act)) return true;
            //}
            

            //123
            //if (SteelFangsInert && DreadFangsInert)
            //{
                if (SteelFangsPvE.CanUse(out act, skipAoeCheck: true)) return true;
            //}
        }

        //ranged
        if (WrithingSnapPvE.CanUse(out act)) return true;
        



        return base.GeneralGCD(out act);
   }
        
   private bool AttackGCD(out IAction? act, bool burst)
   {
        act = null;



       return false;
   }
    #endregion

    #region Extra Methods
    public override void DisplayStatus()
    {
        ImGui.Text("-----VPR");
        ImGui.Text("SteelFangs     " + SteelFangsPvE.AdjustedID.ToString()); //SteelFangs 34606 inert --  34608 Hunter's Sting --  34610 Flanksting Strike -- 34612 Hindsting Strike
        ImGui.Text("DreadFangs     " + DreadFangsPvE.AdjustedID.ToString()); //DreadFangs 34607 inert --  34609 Swiftskin's Sting -- 34611 Flanksbane Fang -- 34613 Hindsbane Fang
        ImGui.Text("SerpentTails     " + SerpentsTailPvE.AdjustedID.ToString()); //SerpentTails 35920 inert -- 34634 DeathRattleReady 
        ImGui.Text("-----VPR AOE");
        ImGui.Text("SteelMaw     " + SteelMawPvE.AdjustedID.ToString());
        ImGui.Text("DreadMaw     " + DreadMawPvE.AdjustedID.ToString());
        ImGui.Text("-----VPR DreadCombo");
        ImGui.Text("DreadCombo 0 " + (DreadCombo == 0).ToString());
        ImGui.Text("DreadCombo Dreadwinder " + (DreadCombo == DreadCombo.Dreadwinder).ToString());
        ImGui.Text("DreadCombo Huntercoil " + (DreadCombo == DreadCombo.HuntersCoil).ToString());



        base.DisplayStatus();
    }
    // Extra private helper methods for determining the usability of specific abilities under certain conditions.
    // These methods simplify the main logic by encapsulating specific checks related to abilities' cooldowns and prerequisites.
    //private bool CanUseExamplePvE(out IAction? act)
    //{

    //}
    #endregion
}