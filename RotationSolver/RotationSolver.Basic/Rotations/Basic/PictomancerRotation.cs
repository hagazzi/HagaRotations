using ECommons.DalamudServices;
using ECommons.ExcelServices;
using RotationSolver.Basic.Actions;
using RotationSolver.Basic.Traits;


namespace RotationSolver.Basic.Rotations.Basic;

/// <summary>
/// <see href="https://na.finalfantasyxiv.com/jobguide/summoner"><strong>summoner</strong></see>
/// <br>Number of Actions: 97</br>
/// <br>Number of Traits: 20</br>
/// </summary>
[Jobs(Job.PCT)]
partial class PictomancerRotation : CustomRotation
{
    public override MedicineType MedicineType => MedicineType.Intelligence;
    static SMNGauge JobGauge => Svc.Gauges.Get<SMNGauge>();

    #region Actions
    private readonly Lazy<IBaseAction> _RuinPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)163, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyRuinPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/163"><strong>Ruin</strong></see> <i>PvE</i> (ACN SMN) [163] [Spell]
    /// </summary>
    static partial void ModifyRuinPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/163"><strong>Ruin</strong></see> <i>PvE</i> (ACN SMN) [163] [Spell]
    /// <para>Deals unaspected damage with a potency of 240.</para>
    /// </summary>

    public IBaseAction RuinPvE => _RuinPvECreator.Value;
    private readonly Lazy<IBaseAction> _RuinIiPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)172, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyRuinIiPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/172"><strong>Ruin II</strong></see> <i>PvE</i> (ACN SMN) [172] [Spell]
    /// </summary>
    static partial void ModifyRuinIiPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/172"><strong>Ruin II</strong></see> <i>PvE</i> (ACN SMN) [172] [Spell]
    /// <para>Deals unaspected damage with a potency of 270.</para>
    /// </summary>

    public IBaseAction RuinIiPvE => _RuinIiPvECreator.Value;
    private readonly Lazy<IBaseAction> _ResurrectionPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)173, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyResurrectionPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/173"><strong>Resurrection</strong></see> <i>PvE</i> (ACN SMN SCH) [173] [Spell]
    /// </summary>
    static partial void ModifyResurrectionPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/173"><strong>Resurrection</strong></see> <i>PvE</i> (ACN SMN SCH) [173] [Spell]
    /// <para>Resurrects target to a weakened state.</para>
    /// </summary>

    public IBaseAction ResurrectionPvE => _ResurrectionPvECreator.Value;
    private readonly Lazy<IBaseAction> _FesterPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)181, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyFesterPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/181"><strong>Fester</strong></see> <i>PvE</i> (ACN SMN) [181] [Ability]
    /// </summary>
    static partial void ModifyFesterPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/181"><strong>Fester</strong></see> <i>PvE</i> (ACN SMN) [181] [Ability]
    /// <para>Deals unaspected damage with a potency of 340.</para>
    /// <para>Aetherflow Gauge Cost: 1</para>
    /// </summary>

    public IBaseAction FesterPvE => _FesterPvECreator.Value;
    private readonly Lazy<IBaseAction> _PainflarePvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)3578, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyPainflarePvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/3578"><strong>Painflare</strong></see> <i>PvE</i> (SMN) [3578] [Ability]
    /// </summary>
    static partial void ModifyPainflarePvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/3578"><strong>Painflare</strong></see> <i>PvE</i> (SMN) [3578] [Ability]
    /// <para>Deals unaspected damage with a potency of 150 to target and all enemies nearby it.</para>
    /// <para>Aetherflow Gauge Cost: 1</para>
    /// </summary>

    public IBaseAction PainflarePvE => _PainflarePvECreator.Value;
    private readonly Lazy<IBaseAction> _RuinIiiPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)3579, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyRuinIiiPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/3579"><strong>Ruin III</strong></see> <i>PvE</i> (SMN) [3579] [Spell]
    /// </summary>
    static partial void ModifyRuinIiiPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/3579"><strong>Ruin III</strong></see> <i>PvE</i> (SMN) [3579] [Spell]
    /// <para>Deals unaspected damage with a potency of .</para>
    /// </summary>

    public IBaseAction RuinIiiPvE => _RuinIiiPvECreator.Value;
    private readonly Lazy<IBaseAction> _DreadwyrmTrancePvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)3581, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyDreadwyrmTrancePvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/3581"><strong>Dreadwyrm Trance</strong></see> <i>PvE</i> (SMN) [3581] [Spell]
    /// </summary>
    static partial void ModifyDreadwyrmTrancePvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/3581"><strong>Dreadwyrm Trance</strong></see> <i>PvE</i> (SMN) [3581] [Spell]
    /// <para>Enters Dreadwyrm Trance.</para>
    /// <para>Duration: 15s</para>
    /// <para>Additional Effect: Changes Ruin III to Astral Impulse and Outburst to Astral Flare</para>
    /// <para>Additional Effect: Grants Ruby Arcanum, Topaz Arcanum, and Emerald Arcanum</para>
    /// <para>Can only be executed in combat and while Carbuncle is summoned.</para>
    /// <para>This action does not share a recast timer with any other actions.</para>
    /// </summary>

    public IBaseAction DreadwyrmTrancePvE => _DreadwyrmTrancePvECreator.Value;
    private readonly Lazy<IBaseAction> _DeathflarePvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)3582, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyDeathflarePvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/3582"><strong>Deathflare</strong></see> <i>PvE</i> (SMN) [3582] [Ability]
    /// </summary>
    static partial void ModifyDeathflarePvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/3582"><strong>Deathflare</strong></see> <i>PvE</i> (SMN) [3582] [Ability]
    /// <para>Deals unaspected damage to target and all enemies nearby it with a potency of 500 for the first enemy, and 60% less for all remaining enemies.</para>
    /// <para>Can only be executed while in Dreadwyrm Trance.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// <para>※Astral Flow changes to Deathflare when requirements for execution are met.</para>
    /// </summary>

    public IBaseAction DeathflarePvE => _DeathflarePvECreator.Value;
    private readonly Lazy<IBaseAction> _RuinIvPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)7426, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyRuinIvPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/7426"><strong>Ruin IV</strong></see> <i>PvE</i> (SMN) [7426] [Spell]
    /// </summary>
    static partial void ModifyRuinIvPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/7426"><strong>Ruin IV</strong></see> <i>PvE</i> (SMN) [7426] [Spell]
    /// <para>Deals unaspected damage to target and all enemies nearby it with a potency of  for the first enemy, and 60% less for all remaining enemies.</para>
    /// <para>Can only be executed while under the effect of Further Ruin.</para>
    /// </summary>

    public IBaseAction RuinIvPvE => _RuinIvPvECreator.Value;
    private readonly Lazy<IBaseAction> _SummonBahamutPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)7427, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifySummonBahamutPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/7427"><strong>Summon Bahamut</strong></see> <i>PvE</i> (SMN) [7427] [Spell]
    /// </summary>
    static partial void ModifySummonBahamutPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/7427"><strong>Summon Bahamut</strong></see> <i>PvE</i> (SMN) [7427] [Spell]
    /// <para>Enters Dreadwyrm Trance and summons Demi-Bahamut to fight your target.</para>
    /// <para>Demi-Bahamut will execute Wyrmwave automatically on the targets attacked by you after summoning.</para>
    /// <para>Increases enmity in target when Demi-Bahamut is summoned.</para>
    /// <para>Duration: 15s</para>
    /// <para>Additional Effect: Changes Ruin III to Astral Impulse and Tri-disasterOutburstOutburst to Astral Flare</para>
    /// <para>Additional Effect: Grants Ruby Arcanum, Topaz Arcanum, and Emerald Arcanum</para>
    /// <para>Can only be executed while Carbuncle is summoned.</para>
    /// <para>This action does not share a recast timer with any other actions.</para>
    /// </summary>

    public IBaseAction SummonBahamutPvE => _SummonBahamutPvECreator.Value;
    private readonly Lazy<IBaseAction> _WyrmwavePvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)7428, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyWyrmwavePvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/7428"><strong>Wyrmwave</strong></see> <i>PvE</i> (SMN) [7428] [Spell]
    /// </summary>
    static partial void ModifyWyrmwavePvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/7428"><strong>Wyrmwave</strong></see> <i>PvE</i> (SMN) [7428] [Spell]
    /// <para>Deals unaspected damage with a potency of 150.</para>
    /// <para>Will only execute while Demi-Bahamut is summoned.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction WyrmwavePvE => _WyrmwavePvECreator.Value;
    private readonly Lazy<IBaseAction> _EnkindleBahamutPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)7429, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyEnkindleBahamutPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/7429"><strong>Enkindle Bahamut</strong></see> <i>PvE</i> (SMN) [7429] [Ability]
    /// </summary>
    static partial void ModifyEnkindleBahamutPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/7429"><strong>Enkindle Bahamut</strong></see> <i>PvE</i> (SMN) [7429] [Ability]
    /// <para>Orders Demi-Bahamut to execute Akh Morn.</para>
    /// <para>Akh Morn Effect: Deals unaspected damage to target and all enemies nearby it with a potency of 1,300 for the first enemy, and 60% less for all remaining enemies</para>
    /// </summary>

    public IBaseAction EnkindleBahamutPvE => _EnkindleBahamutPvECreator.Value;
    private readonly Lazy<IBaseAction> _AkhMornPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)7449, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyAkhMornPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/7449"><strong>Akh Morn</strong></see> <i>PvE</i> (SMN) [7449] [Ability]
    /// </summary>
    static partial void ModifyAkhMornPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/7449"><strong>Akh Morn</strong></see> <i>PvE</i> (SMN) [7449] [Ability]
    /// <para>Deals unaspected damage to target and all enemies nearby it with a potency of 1,300 for the first enemy, and 60% less for all remaining enemies.</para>
    /// <para>Can only be executed while Demi-Bahamut is summoned.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction AkhMornPvE => _AkhMornPvECreator.Value;
    private readonly Lazy<IBaseAction> _PhysickPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)16230, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyPhysickPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/16230"><strong>Physick</strong></see> <i>PvE</i> (ACN SMN) [16230] [Spell]
    /// </summary>
    static partial void ModifyPhysickPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/16230"><strong>Physick</strong></see> <i>PvE</i> (ACN SMN) [16230] [Spell]
    /// <para>Restores target's HP.</para>
    /// <para>Cure Potency: 400</para>
    /// </summary>

    public IBaseAction PhysickPvE => _PhysickPvECreator.Value;
    private readonly Lazy<IBaseAction> _EnergyDrainPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)16508, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyEnergyDrainPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/16508"><strong>Energy Drain</strong></see> <i>PvE</i> (ACN SMN) [16508] [Ability]
    /// </summary>
    static partial void ModifyEnergyDrainPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/16508"><strong>Energy Drain</strong></see> <i>PvE</i> (ACN SMN) [16508] [Ability]
    /// <para>Deals unaspected damage with a potency of 200.</para>
    /// <para>Additional Effect: Aetherflow II</para>
    /// <para>Additional Effect: Grants Further Ruin</para>
    /// <para>Duration: 60s</para>
    /// <para>Shares a recast timer with Energy Siphon.</para>
    /// </summary>

    public IBaseAction EnergyDrainPvE => _EnergyDrainPvECreator.Value;
    private readonly Lazy<IBaseAction> _EnergySiphonPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)16510, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyEnergySiphonPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/16510"><strong>Energy Siphon</strong></see> <i>PvE</i> (SMN) [16510] [Ability]
    /// </summary>
    static partial void ModifyEnergySiphonPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/16510"><strong>Energy Siphon</strong></see> <i>PvE</i> (SMN) [16510] [Ability]
    /// <para>Deals unaspected damage with a potency of 100 to target and all enemies nearby it.</para>
    /// <para>Additional Effect: Aetherflow II</para>
    /// <para>Additional Effect: Grants Further Ruin</para>
    /// <para>Duration: 60s</para>
    /// <para>Shares a recast timer with Energy Drain.</para>
    /// </summary>

    public IBaseAction EnergySiphonPvE => _EnergySiphonPvECreator.Value;
    private readonly Lazy<IBaseAction> _OutburstPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)16511, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyOutburstPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/16511"><strong>Outburst</strong></see> <i>PvE</i> (ACN SMN) [16511] [Spell]
    /// </summary>
    static partial void ModifyOutburstPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/16511"><strong>Outburst</strong></see> <i>PvE</i> (ACN SMN) [16511] [Spell]
    /// <para>Deals unaspected damage with a potency of 100 to target and all enemies nearby it.</para>
    /// </summary>

    public IBaseAction OutburstPvE => _OutburstPvECreator.Value;
    private readonly Lazy<IBaseAction> _FountainOfFirePvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)16514, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyFountainOfFirePvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/16514"><strong>Fountain of Fire</strong></see> <i>PvE</i> (SMN) [16514] [Spell]
    /// </summary>
    static partial void ModifyFountainOfFirePvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/16514"><strong>Fountain of Fire</strong></see> <i>PvE</i> (SMN) [16514] [Spell]
    /// <para>Deals fire damage with a potency of .</para>
    /// <para>Can only be executed while under the effect of Firebird Trance.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// <para>※Ruin III changes to Fountain of Fire when requirements for execution are met.</para>
    /// </summary>

    public IBaseAction FountainOfFirePvE => _FountainOfFirePvECreator.Value;
    private readonly Lazy<IBaseAction> _BrandOfPurgatoryPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)16515, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyBrandOfPurgatoryPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/16515"><strong>Brand of Purgatory</strong></see> <i>PvE</i> (SMN) [16515] [Spell]
    /// </summary>
    static partial void ModifyBrandOfPurgatoryPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/16515"><strong>Brand of Purgatory</strong></see> <i>PvE</i> (SMN) [16515] [Spell]
    /// <para>Deals fire damage with a potency of 240 to target and all enemies nearby it.</para>
    /// <para>Can only be executed while under the effect of Firebird Trance.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// <para>※Tri-disaster changes to Brand of Purgatory when requirements for execution are met.</para>
    /// </summary>

    public IBaseAction BrandOfPurgatoryPvE => _BrandOfPurgatoryPvECreator.Value;
    private readonly Lazy<IBaseAction> _EnkindlePhoenixPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)16516, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyEnkindlePhoenixPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/16516"><strong>Enkindle Phoenix</strong></see> <i>PvE</i> (SMN) [16516] [Ability]
    /// </summary>
    static partial void ModifyEnkindlePhoenixPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/16516"><strong>Enkindle Phoenix</strong></see> <i>PvE</i> (SMN) [16516] [Ability]
    /// <para>Orders Demi-Phoenix to execute Revelation.</para>
    /// <para>Revelation Effect: Deals fire damage to target and all enemies nearby it with a potency of 1,300 for the first enemy, and 60% less for all remaining enemies</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// <para>※Enkindle Bahamut changes to Enkindle Phoenix when requirements for execution are met.</para>
    /// </summary>

    public IBaseAction EnkindlePhoenixPvE => _EnkindlePhoenixPvECreator.Value;
    private readonly Lazy<IBaseAction> _EverlastingFlightPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)16517, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyEverlastingFlightPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/16517"><strong>Everlasting Flight</strong></see> <i>PvE</i> (SMN) [16517] [Ability]
    /// </summary>
    static partial void ModifyEverlastingFlightPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/16517"><strong>Everlasting Flight</strong></see> <i>PvE</i> (SMN) [16517] [Ability]
    /// <para>Gradually restores own HP and the HP of all nearby party members.</para>
    /// <para>Cure Potency: 100</para>
    /// <para>Duration: 21s</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction EverlastingFlightPvE => _EverlastingFlightPvECreator.Value;
    private readonly Lazy<IBaseAction> _RevelationPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)16518, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyRevelationPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/16518"><strong>Revelation</strong></see> <i>PvE</i> (SMN) [16518] [Ability]
    /// </summary>
    static partial void ModifyRevelationPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/16518"><strong>Revelation</strong></see> <i>PvE</i> (SMN) [16518] [Ability]
    /// <para>Deals fire damage to target and all enemies nearby it with a potency of 1,300 for the first enemy, and 60% less for all remaining enemies.</para>
    /// <para>Can only be executed while Demi-Phoenix is summoned.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction RevelationPvE => _RevelationPvECreator.Value;
    private readonly Lazy<IBaseAction> _ScarletFlamePvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)16519, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyScarletFlamePvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/16519"><strong>Scarlet Flame</strong></see> <i>PvE</i> (SMN) [16519] [Spell]
    /// </summary>
    static partial void ModifyScarletFlamePvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/16519"><strong>Scarlet Flame</strong></see> <i>PvE</i> (SMN) [16519] [Spell]
    /// <para>Deals fire damage with a potency of 150.</para>
    /// <para>Will only execute while Demi-Phoenix is summoned.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction ScarletFlamePvE => _ScarletFlamePvECreator.Value;
    private readonly Lazy<IBaseAction> _SummonCarbunclePvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25798, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifySummonCarbunclePvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25798"><strong>Summon Carbuncle</strong></see> <i>PvE</i> (ACN SMN) [25798] [Spell]
    /// </summary>
    static partial void ModifySummonCarbunclePvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25798"><strong>Summon Carbuncle</strong></see> <i>PvE</i> (ACN SMN) [25798] [Spell]
    /// <para>Summons Carbuncle to your side.</para>
    /// </summary>

    public IBaseAction SummonCarbunclePvE => _SummonCarbunclePvECreator.Value;
    private readonly Lazy<IBaseAction> _RadiantAegisPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25799, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyRadiantAegisPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25799"><strong>Radiant Aegis</strong></see> <i>PvE</i> (ACN SMN) [25799] [Ability]
    /// </summary>
    static partial void ModifyRadiantAegisPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25799"><strong>Radiant Aegis</strong></see> <i>PvE</i> (ACN SMN) [25799] [Ability]
    /// <para>Orders Carbuncle to execute Radiant Aegis.</para>
    /// <para>Radiant Aegis Effect: Creates a barrier around self that absorbs damage totaling 20% of your maximum HP</para>
    /// <para>Duration: 30s</para>
    /// <para>Maximum Charges: 2</para>
    /// <para>Can only be executed while Carbuncle is summoned.</para>
    /// </summary>

    public IBaseAction RadiantAegisPvE => _RadiantAegisPvECreator.Value;
    private readonly Lazy<IBaseAction> _AetherchargePvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25800, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyAetherchargePvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25800"><strong>Aethercharge</strong></see> <i>PvE</i> (ACN SMN) [25800] [Spell]
    /// </summary>
    static partial void ModifyAetherchargePvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25800"><strong>Aethercharge</strong></see> <i>PvE</i> (ACN SMN) [25800] [Spell]
    /// <para>Grants Aethercharge, increasing the potency of Ruin, Ruin II, and Ruin III by 50, and Outburst by 20.</para>
    /// <para>Duration: 15s</para>
    /// <para>Additional Effect: Grants Ruby Arcanum, Topaz Arcanum, and Emerald ArcanumRuby Arcanum, Topaz Arcanum, and Emerald ArcanumRuby Arcanum and Topaz ArcanumRuby Arcanum and Topaz ArcanumRuby ArcanumRuby ArcanumRuby Arcanum and Topaz ArcanumRuby Arcanum and Topaz ArcanumRuby ArcanumRuby Arcanum</para>
    /// <para>Can only be executed in combat and while Carbuncle is summoned.</para>
    /// </summary>

    public IBaseAction AetherchargePvE => _AetherchargePvECreator.Value;
    private readonly Lazy<IBaseAction> _SearingLightPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25801, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifySearingLightPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25801"><strong>Searing Light</strong></see> <i>PvE</i> (SMN) [25801] [Ability]
    /// </summary>
    static partial void ModifySearingLightPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25801"><strong>Searing Light</strong></see> <i>PvE</i> (SMN) [25801] [Ability]
    /// <para>Increases damage dealt by self and nearby party members by 5%.</para>
    /// <para>Duration: 20s</para>
    /// <para>Additional Effect: Grants Ruby's Glimmer</para>
    /// <para>Duration: 30s</para>
    /// </summary>

    public IBaseAction SearingLightPvE => _SearingLightPvECreator.Value;
    private readonly Lazy<IBaseAction> _SummonRubyPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25802, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifySummonRubyPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25802"><strong>Summon Ruby</strong></see> <i>PvE</i> (ACN SMN) [25802] [Spell]
    /// </summary>
    static partial void ModifySummonRubyPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25802"><strong>Summon Ruby</strong></see> <i>PvE</i> (ACN SMN) [25802] [Spell]
    /// <para>Summons Ruby Carbuncle, and orders it to execute Glittering Ruby.</para>
    /// <para>Glittering Ruby Effect: Rushes target and deals fire damage with a potency of 400</para>
    /// <para>Additional Effect: Grants 2 stacks of Fire Attunement</para>
    /// <para>Fire Attunement Effect: Gemshine and Precious Brilliance become fire-aspected</para>
    /// <para>Duration: 30s</para>
    /// <para>Can only be executed while under the effect of Ruby Arcanum and Carbuncle is summoned.</para>
    /// <para>Current pet will leave the battlefield while Ruby Carbuncle is present, and return once gone.</para>
    /// </summary>

    public IBaseAction SummonRubyPvE => _SummonRubyPvECreator.Value;
    private readonly Lazy<IBaseAction> _SummonTopazPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25803, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifySummonTopazPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25803"><strong>Summon Topaz</strong></see> <i>PvE</i> (ACN SMN) [25803] [Spell]
    /// </summary>
    static partial void ModifySummonTopazPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25803"><strong>Summon Topaz</strong></see> <i>PvE</i> (ACN SMN) [25803] [Spell]
    /// <para>Summons Topaz Carbuncle, and orders it to execute Glittering Topaz.</para>
    /// <para>Glittering Topaz Effect: Rushes target and deals earth damage with a potency of 400</para>
    /// <para>Additional Effect: Grants 4 stacks of Earth Attunement</para>
    /// <para>Earth Attunement Effect: Gemshine and Precious Brilliance become earth-aspected</para>
    /// <para>Duration: 30s</para>
    /// <para>Can only be executed while under the effect of Topaz Arcanum and Carbuncle is summoned.</para>
    /// <para>Current pet will leave the battlefield while Topaz Carbuncle is present, and return once gone.</para>
    /// </summary>

    public IBaseAction SummonTopazPvE => _SummonTopazPvECreator.Value;
    private readonly Lazy<IBaseAction> _SummonEmeraldPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25804, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifySummonEmeraldPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25804"><strong>Summon Emerald</strong></see> <i>PvE</i> (ACN SMN) [25804] [Spell]
    /// </summary>
    static partial void ModifySummonEmeraldPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25804"><strong>Summon Emerald</strong></see> <i>PvE</i> (ACN SMN) [25804] [Spell]
    /// <para>Summons Emerald Carbuncle, and orders it to execute Glittering Emerald.</para>
    /// <para>Glittering Emerald Effect: Deals wind damage with a potency of 400</para>
    /// <para>Additional Effect: Grants 4 stacks of Wind Attunement</para>
    /// <para>Wind Attunement Effect: Gemshine and Precious Brilliance become wind-aspected</para>
    /// <para>Duration: 30s</para>
    /// <para>Can only be executed while under the effect of Emerald Arcanum and Carbuncle is summoned.</para>
    /// <para>Current pet will leave the battlefield while Emerald Carbuncle is present, and return once gone.</para>
    /// </summary>

    public IBaseAction SummonEmeraldPvE => _SummonEmeraldPvECreator.Value;
    private readonly Lazy<IBaseAction> _SummonIfritPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25805, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifySummonIfritPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25805"><strong>Summon Ifrit</strong></see> <i>PvE</i> (SMN) [25805] [Spell]
    /// </summary>
    static partial void ModifySummonIfritPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25805"><strong>Summon Ifrit</strong></see> <i>PvE</i> (SMN) [25805] [Spell]
    /// <para>Summons Ifrit-Egi and orders it to execute InfernoBurning StrikeBurning Strike.</para>
    /// <para>Inferno Effect: Rushes forward and deals fire damage to all enemies in a 5-yalm cone before it with a potency of 600 for the first enemy, and 60% less for all remaining enemiesBurning Strike Effect: Rushes forward and deals fire damage with a potency of 500Burning Strike Effect: Rushes forward and deals fire damage with a potency of 500</para>
    /// <para>Additional Effect: Grants 2 stacks of Fire Attunement</para>
    /// <para>Fire Attunement Effect: Gemshine and Precious Brilliance become fire-aspected</para>
    /// <para>Duration: 30s</para>
    /// <para>Additional Effect: Grants Ifrit's Favor</para>
    /// <para>Effect of Ifrit's Favor ends upon execution of certain summoner actions.</para>
    /// <para>Can only be executed while under the effect of Ruby Arcanum and Carbuncle is summoned.</para>
    /// <para>Current pet will leave the battlefield while Ifrit-Egi is present, and return once gone.</para>
    /// </summary>

    public IBaseAction SummonIfritPvE => _SummonIfritPvECreator.Value;
    private readonly Lazy<IBaseAction> _SummonTitanPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25806, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifySummonTitanPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25806"><strong>Summon Titan</strong></see> <i>PvE</i> (SMN) [25806] [Spell]
    /// </summary>
    static partial void ModifySummonTitanPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25806"><strong>Summon Titan</strong></see> <i>PvE</i> (SMN) [25806] [Spell]
    /// <para>Summons Titan-Egi and orders it to execute Earthen FuryRock BusterRock Buster.</para>
    /// <para>Earthen Fury Effect: Rushes forward and deals earth damage to all enemies within 5 yalms with a potency of 600 for the first enemy, and 60% less for all remaining enemiesRock Buster Effect: Rushes forward and deals earth damage with a potency of 500Rock Buster Effect: Rushes forward and deals earth damage with a potency of 500</para>
    /// <para>Additional Effect: Grants 4 stacks of Earth Attunement</para>
    /// <para>Earth Attunement Effect: Gemshine and Precious Brilliance become earth-aspected</para>
    /// <para>Duration: 30s</para>
    /// <para>Can only be executed while under the effect of Topaz Arcanum and Carbuncle is summoned.</para>
    /// <para>Current pet will leave the battlefield while Titan-Egi is present, and return once gone.</para>
    /// </summary>

    public IBaseAction SummonTitanPvE => _SummonTitanPvECreator.Value;
    private readonly Lazy<IBaseAction> _SummonGarudaPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25807, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifySummonGarudaPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25807"><strong>Summon Garuda</strong></see> <i>PvE</i> (SMN) [25807] [Spell]
    /// </summary>
    static partial void ModifySummonGarudaPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25807"><strong>Summon Garuda</strong></see> <i>PvE</i> (SMN) [25807] [Spell]
    /// <para>Summons Garuda-Egi and orders it to execute Aerial BlastAerial SlashAerial Slash.</para>
    /// <para>Aerial Blast Effect: Deals wind damage to target and all enemies within 5 yalms with a potency of 600 for the first enemy, and 60% less for all remaining enemiesAerial Slash Effect: Deals wind damage with a potency of 100 to target and all enemies nearby itAerial Slash Effect: Deals wind damage with a potency of 100 to target and all enemies nearby it</para>
    /// <para>Additional Effect: Grants 4 stacks of Wind Attunement</para>
    /// <para>Wind Attunement Effect: Gemshine and Precious Brilliance become wind-aspected</para>
    /// <para>Duration: 30s</para>
    /// <para>Additional Effect: Grants Garuda's Favor</para>
    /// <para>Effect of Garuda's Favor ends upon execution of certain summoner actions.</para>
    /// <para>Can only be executed while under the effect of Emerald Arcanum and Carbuncle is summoned.</para>
    /// <para>Current pet will leave the battlefield while Garuda-Egi is present, and return once gone.</para>
    /// </summary>

    public IBaseAction SummonGarudaPvE => _SummonGarudaPvECreator.Value;
    private readonly Lazy<IBaseAction> _RubyRuinPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25808, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyRubyRuinPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25808"><strong>Ruby Ruin</strong></see> <i>PvE</i> (ACN SMN) [25808] [Spell]
    /// </summary>
    static partial void ModifyRubyRuinPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25808"><strong>Ruby Ruin</strong></see> <i>PvE</i> (ACN SMN) [25808] [Spell]
    /// <para>Deals fire damage with a potency of 340.</para>
    /// <para>Fire Attunement Cost: 1</para>
    /// <para>This action does not share a recast timer with any other actions. Upon execution, the recast timer for this action will be applied to all other weaponskills and magic actions.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction RubyRuinPvE => _RubyRuinPvECreator.Value;
    private readonly Lazy<IBaseAction> _TopazRuinPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25809, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyTopazRuinPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25809"><strong>Topaz Ruin</strong></see> <i>PvE</i> (ACN SMN) [25809] [Spell]
    /// </summary>
    static partial void ModifyTopazRuinPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25809"><strong>Topaz Ruin</strong></see> <i>PvE</i> (ACN SMN) [25809] [Spell]
    /// <para>Deals earth damage with a potency of 240.</para>
    /// <para>Earth Attunement Cost: 1</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction TopazRuinPvE => _TopazRuinPvECreator.Value;
    private readonly Lazy<IBaseAction> _EmeraldRuinPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25810, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyEmeraldRuinPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25810"><strong>Emerald Ruin</strong></see> <i>PvE</i> (ACN SMN) [25810] [Spell]
    /// </summary>
    static partial void ModifyEmeraldRuinPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25810"><strong>Emerald Ruin</strong></see> <i>PvE</i> (ACN SMN) [25810] [Spell]
    /// <para>Deals wind damage with a potency of 160.</para>
    /// <para>Wind Attunement Cost: 1</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction EmeraldRuinPvE => _EmeraldRuinPvECreator.Value;
    private readonly Lazy<IBaseAction> _RubyRuinIiPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25811, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyRubyRuinIiPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25811"><strong>Ruby Ruin II</strong></see> <i>PvE</i> (ACN SMN) [25811] [Spell]
    /// </summary>
    static partial void ModifyRubyRuinIiPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25811"><strong>Ruby Ruin II</strong></see> <i>PvE</i> (ACN SMN) [25811] [Spell]
    /// <para>Deals fire damage with a potency of 380.</para>
    /// <para>Fire Attunement Cost: 1</para>
    /// <para>This action does not share a recast timer with any other actions. Upon execution, the recast timer for this action will be applied to all other weaponskills and magic actions.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction RubyRuinIiPvE => _RubyRuinIiPvECreator.Value;
    private readonly Lazy<IBaseAction> _TopazRuinIiPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25812, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyTopazRuinIiPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25812"><strong>Topaz Ruin II</strong></see> <i>PvE</i> (ACN SMN) [25812] [Spell]
    /// </summary>
    static partial void ModifyTopazRuinIiPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25812"><strong>Topaz Ruin II</strong></see> <i>PvE</i> (ACN SMN) [25812] [Spell]
    /// <para>Deals earth damage with a potency of 270.</para>
    /// <para>Earth Attunement Cost: 1</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction TopazRuinIiPvE => _TopazRuinIiPvECreator.Value;
    private readonly Lazy<IBaseAction> _EmeraldRuinIiPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25813, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyEmeraldRuinIiPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25813"><strong>Emerald Ruin II</strong></see> <i>PvE</i> (ACN SMN) [25813] [Spell]
    /// </summary>
    static partial void ModifyEmeraldRuinIiPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25813"><strong>Emerald Ruin II</strong></see> <i>PvE</i> (ACN SMN) [25813] [Spell]
    /// <para>Deals wind damage with a potency of 170.</para>
    /// <para>Wind Attunement Cost: 1</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction EmeraldRuinIiPvE => _EmeraldRuinIiPvECreator.Value;
    private readonly Lazy<IBaseAction> _RubyOutburstPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25814, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyRubyOutburstPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25814"><strong>Ruby Outburst</strong></see> <i>PvE</i> (ACN SMN) [25814] [Spell]
    /// </summary>
    static partial void ModifyRubyOutburstPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25814"><strong>Ruby Outburst</strong></see> <i>PvE</i> (ACN SMN) [25814] [Spell]
    /// <para>Deals fire damage with a potency of 160 to target and all enemies nearby it.</para>
    /// <para>Fire Attunement Cost: 1</para>
    /// <para>This action does not share a recast timer with any other actions. Upon execution, the recast timer for this action will be applied to all other weaponskills and magic actions.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction RubyOutburstPvE => _RubyOutburstPvECreator.Value;
    private readonly Lazy<IBaseAction> _TopazOutburstPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25815, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyTopazOutburstPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25815"><strong>Topaz Outburst</strong></see> <i>PvE</i> (ACN SMN) [25815] [Spell]
    /// </summary>
    static partial void ModifyTopazOutburstPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25815"><strong>Topaz Outburst</strong></see> <i>PvE</i> (ACN SMN) [25815] [Spell]
    /// <para>Deals earth damage with a potency of 110 to target and all enemies nearby it.</para>
    /// <para>Earth Attunement Cost: 1</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction TopazOutburstPvE => _TopazOutburstPvECreator.Value;
    private readonly Lazy<IBaseAction> _EmeraldOutburstPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25816, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyEmeraldOutburstPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25816"><strong>Emerald Outburst</strong></see> <i>PvE</i> (ACN SMN) [25816] [Spell]
    /// </summary>
    static partial void ModifyEmeraldOutburstPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25816"><strong>Emerald Outburst</strong></see> <i>PvE</i> (ACN SMN) [25816] [Spell]
    /// <para>Deals wind damage with a potency of 70 to target and all enemies nearby it.</para>
    /// <para>Wind Attunement Cost: 1</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction EmeraldOutburstPvE => _EmeraldOutburstPvECreator.Value;
    private readonly Lazy<IBaseAction> _RubyRuinIiiPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25817, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyRubyRuinIiiPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25817"><strong>Ruby Ruin III</strong></see> <i>PvE</i> (SMN) [25817] [Spell]
    /// </summary>
    static partial void ModifyRubyRuinIiiPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25817"><strong>Ruby Ruin III</strong></see> <i>PvE</i> (SMN) [25817] [Spell]
    /// <para>Deals fire damage with a potency of 410.</para>
    /// <para>Fire Attunement Cost: 1</para>
    /// <para>This action does not share a recast timer with any other actions. Upon execution, the recast timer for this action will be applied to all other weaponskills and magic actions.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction RubyRuinIiiPvE => _RubyRuinIiiPvECreator.Value;
    private readonly Lazy<IBaseAction> _TopazRuinIiiPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25818, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyTopazRuinIiiPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25818"><strong>Topaz Ruin III</strong></see> <i>PvE</i> (SMN) [25818] [Spell]
    /// </summary>
    static partial void ModifyTopazRuinIiiPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25818"><strong>Topaz Ruin III</strong></see> <i>PvE</i> (SMN) [25818] [Spell]
    /// <para>Deals earth damage with a potency of 300.</para>
    /// <para>Earth Attunement Cost: 1</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction TopazRuinIiiPvE => _TopazRuinIiiPvECreator.Value;
    private readonly Lazy<IBaseAction> _EmeraldRuinIiiPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25819, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyEmeraldRuinIiiPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25819"><strong>Emerald Ruin III</strong></see> <i>PvE</i> (SMN) [25819] [Spell]
    /// </summary>
    static partial void ModifyEmeraldRuinIiiPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25819"><strong>Emerald Ruin III</strong></see> <i>PvE</i> (SMN) [25819] [Spell]
    /// <para>Deals wind damage with a potency of 180.</para>
    /// <para>Wind Attunement Cost: 1</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction EmeraldRuinIiiPvE => _EmeraldRuinIiiPvECreator.Value;
    private readonly Lazy<IBaseAction> _AstralImpulsePvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25820, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyAstralImpulsePvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25820"><strong>Astral Impulse</strong></see> <i>PvE</i> (SMN) [25820] [Spell]
    /// </summary>
    static partial void ModifyAstralImpulsePvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25820"><strong>Astral Impulse</strong></see> <i>PvE</i> (SMN) [25820] [Spell]
    /// <para>Deals unaspected damage with a potency of .</para>
    /// <para>Can only be executed while in Dreadwyrm Trance.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// <para>※Ruin III changes to Astral Impulse when requirements for execution are met.</para>
    /// </summary>

    public IBaseAction AstralImpulsePvE => _AstralImpulsePvECreator.Value;
    private readonly Lazy<IBaseAction> _AstralFlarePvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25821, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyAstralFlarePvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25821"><strong>Astral Flare</strong></see> <i>PvE</i> (SMN) [25821] [Spell]
    /// </summary>
    static partial void ModifyAstralFlarePvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25821"><strong>Astral Flare</strong></see> <i>PvE</i> (SMN) [25821] [Spell]
    /// <para>Deals unaspected damage with a potency of 180 to target and all enemies nearby it.</para>
    /// <para>Can only be executed while in Dreadwyrm Trance.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// <para>※Tri-disasterOutburstOutburst changes to Astral Flare when requirements for execution are met.</para>
    /// </summary>

    public IBaseAction AstralFlarePvE => _AstralFlarePvECreator.Value;
    private readonly Lazy<IBaseAction> _AstralFlowPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25822, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyAstralFlowPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25822"><strong>Astral Flow</strong></see> <i>PvE</i> (SMN) [25822] [Spell]
    /// </summary>
    static partial void ModifyAstralFlowPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25822"><strong>Astral Flow</strong></see> <i>PvE</i> (SMN) [25822] [Spell]
    /// <para>Channel the energies of your active trance or elemental favor to perform one of several actions.</para>
    /// <para>Dreadwyrm Trance Effect: Action changes to Deathflare</para>
    /// <para>Lightwyrm Trance Effect: Action changes to Sunflare</para>
    /// <para>Firebird Trance Effect: Action changes to Rekindle</para>
    /// <para>Ifrit's Favor Effect: Action changes to Crimson Cyclone</para>
    /// <para>Titan's Favor Effect: Action changes to Mountain Buster</para>
    /// <para>Garuda's Favor Effect: Action changes to Slipstream</para>
    /// </summary>

    public IBaseAction AstralFlowPvE => _AstralFlowPvECreator.Value;
    private readonly Lazy<IBaseAction> _RubyRitePvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25823, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyRubyRitePvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25823"><strong>Ruby Rite</strong></see> <i>PvE</i> (SMN) [25823] [Spell]
    /// </summary>
    static partial void ModifyRubyRitePvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25823"><strong>Ruby Rite</strong></see> <i>PvE</i> (SMN) [25823] [Spell]
    /// <para>Deals fire damage with a potency of .</para>
    /// <para>Fire Attunement Cost: 1</para>
    /// <para>This action does not share a recast timer with any other actions. Upon execution, the recast timer for this action will be applied to all other weaponskills and magic actions.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// <para>※Gemshine changes to Ruby Rite when requirements for execution are met.</para>
    /// </summary>

    public IBaseAction RubyRitePvE => _RubyRitePvECreator.Value;
    private readonly Lazy<IBaseAction> _TopazRitePvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25824, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyTopazRitePvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25824"><strong>Topaz Rite</strong></see> <i>PvE</i> (SMN) [25824] [Spell]
    /// </summary>
    static partial void ModifyTopazRitePvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25824"><strong>Topaz Rite</strong></see> <i>PvE</i> (SMN) [25824] [Spell]
    /// <para>Deals earth damage with a potency of .</para>
    /// <para>Additional Effect: Grants Titan's Favor</para>
    /// <para>Effect of Titan's Favor ends upon execution of certain summoner actions.</para>
    /// <para>Earth Attunement Cost: 1</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// <para>※Gemshine changes to Topaz Rite when requirements for execution are met.</para>
    /// </summary>

    public IBaseAction TopazRitePvE => _TopazRitePvECreator.Value;
    private readonly Lazy<IBaseAction> _EmeraldRitePvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25825, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyEmeraldRitePvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25825"><strong>Emerald Rite</strong></see> <i>PvE</i> (SMN) [25825] [Spell]
    /// </summary>
    static partial void ModifyEmeraldRitePvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25825"><strong>Emerald Rite</strong></see> <i>PvE</i> (SMN) [25825] [Spell]
    /// <para>Deals wind damage with a potency of .</para>
    /// <para>Wind Attunement Cost: 1</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// <para>※Gemshine changes to Emerald Rite when requirements for execution are met.</para>
    /// </summary>

    public IBaseAction EmeraldRitePvE => _EmeraldRitePvECreator.Value;
    private readonly Lazy<IBaseAction> _TridisasterPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25826, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyTridisasterPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25826"><strong>Tri-disaster</strong></see> <i>PvE</i> (SMN) [25826] [Spell]
    /// </summary>
    static partial void ModifyTridisasterPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25826"><strong>Tri-disaster</strong></see> <i>PvE</i> (SMN) [25826] [Spell]
    /// <para>Deals unaspected damage with a potency of 120 to target and all enemies nearby it.</para>
    /// </summary>

    public IBaseAction TridisasterPvE => _TridisasterPvECreator.Value;
    private readonly Lazy<IBaseAction> _RubyDisasterPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25827, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyRubyDisasterPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25827"><strong>Ruby Disaster</strong></see> <i>PvE</i> (SMN) [25827] [Spell]
    /// </summary>
    static partial void ModifyRubyDisasterPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25827"><strong>Ruby Disaster</strong></see> <i>PvE</i> (SMN) [25827] [Spell]
    /// <para>Deals fire damage with a potency of 190 to target and all enemies nearby it.</para>
    /// <para>Fire Attunement Cost: 1</para>
    /// <para>This action does not share a recast timer with any other actions. Upon execution, the recast timer for this action will be applied to all other weaponskills and magic actions.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction RubyDisasterPvE => _RubyDisasterPvECreator.Value;
    private readonly Lazy<IBaseAction> _TopazDisasterPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25828, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyTopazDisasterPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25828"><strong>Topaz Disaster</strong></see> <i>PvE</i> (SMN) [25828] [Spell]
    /// </summary>
    static partial void ModifyTopazDisasterPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25828"><strong>Topaz Disaster</strong></see> <i>PvE</i> (SMN) [25828] [Spell]
    /// <para>Deals earth damage with a potency of 130 to target and all enemies nearby it.</para>
    /// <para>Earth Attunement Cost: 1</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction TopazDisasterPvE => _TopazDisasterPvECreator.Value;
    private readonly Lazy<IBaseAction> _EmeraldDisasterPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25829, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyEmeraldDisasterPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25829"><strong>Emerald Disaster</strong></see> <i>PvE</i> (SMN) [25829] [Spell]
    /// </summary>
    static partial void ModifyEmeraldDisasterPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25829"><strong>Emerald Disaster</strong></see> <i>PvE</i> (SMN) [25829] [Spell]
    /// <para>Deals wind damage with a potency of 90 to target and all enemies nearby it.</para>
    /// <para>Wind Attunement Cost: 1</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction EmeraldDisasterPvE => _EmeraldDisasterPvECreator.Value;
    private readonly Lazy<IBaseAction> _RekindlePvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25830, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyRekindlePvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25830"><strong>Rekindle</strong></see> <i>PvE</i> (SMN) [25830] [Ability]
    /// </summary>
    static partial void ModifyRekindlePvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25830"><strong>Rekindle</strong></see> <i>PvE</i> (SMN) [25830] [Ability]
    /// <para>Restores own or target party member's HP.</para>
    /// <para>Cure Potency: 400</para>
    /// <para>Additional Effect: Grants Rekindle to target</para>
    /// <para>Duration: 30s</para>
    /// <para>Rekindle Effect: Healing over time when HP falls below 75% or upon effect duration expiration</para>
    /// <para>Cure Potency: 200</para>
    /// <para>Duration: 15s</para>
    /// <para>Can only be executed while in Firebird Trance.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// <para>※Astral Flow changes to Rekindle when requirements for execution are met.</para>
    /// </summary>

    public IBaseAction RekindlePvE => _RekindlePvECreator.Value;
    private readonly Lazy<IBaseAction> _SummonPhoenixPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25831, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifySummonPhoenixPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25831"><strong>Summon Phoenix</strong></see> <i>PvE</i> (SMN) [25831] [Spell]
    /// </summary>
    static partial void ModifySummonPhoenixPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25831"><strong>Summon Phoenix</strong></see> <i>PvE</i> (SMN) [25831] [Spell]
    /// <para>Enters Firebird Trance and summons Demi-Phoenix to fight by your side, which executes Everlasting Flight as it manifests.</para>
    /// <para>Demi-Phoenix will execute Scarlet Flame automatically on the targets attacked by you after summoning.</para>
    /// <para>Increases enmity in target when Demi-Phoenix is summoned.</para>
    /// <para>Duration: 15s</para>
    /// <para>Additional Effect: Changes Ruin III to Fountain of Fire and Tri-disaster to Brand of Purgatory</para>
    /// <para>Additional Effect: Grants Ruby Arcanum, Topaz Arcanum, and Emerald Arcanum</para>
    /// <para>Can only be executed while Carbuncle is summoned.</para>
    /// <para>This action does not share a recast timer with any other actions.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// <para>※Summon Bahamut changes to Summon Phoenix when requirements for execution are met.</para>
    /// </summary>

    public IBaseAction SummonPhoenixPvE => _SummonPhoenixPvECreator.Value;
    private readonly Lazy<IBaseAction> _RubyCatastrophePvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25832, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyRubyCatastrophePvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25832"><strong>Ruby Catastrophe</strong></see> <i>PvE</i> (SMN) [25832] [Spell]
    /// </summary>
    static partial void ModifyRubyCatastrophePvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25832"><strong>Ruby Catastrophe</strong></see> <i>PvE</i> (SMN) [25832] [Spell]
    /// <para>Deals fire damage with a potency of 210 to target and all enemies nearby it.</para>
    /// <para>Fire Attunement Cost: 1</para>
    /// <para>This action does not share a recast timer with any other actions. Upon execution, the recast timer for this action will be applied to all other weaponskills and magic actions.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// <para>※Precious Brilliance changes to Ruby Catastrophe when requirements for execution are met.</para>
    /// </summary>

    public IBaseAction RubyCatastrophePvE => _RubyCatastrophePvECreator.Value;
    private readonly Lazy<IBaseAction> _TopazCatastrophePvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25833, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyTopazCatastrophePvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25833"><strong>Topaz Catastrophe</strong></see> <i>PvE</i> (SMN) [25833] [Spell]
    /// </summary>
    static partial void ModifyTopazCatastrophePvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25833"><strong>Topaz Catastrophe</strong></see> <i>PvE</i> (SMN) [25833] [Spell]
    /// <para>Deals earth damage with a potency of 140 to target and all enemies nearby it.</para>
    /// <para>Additional Effect: Grants Titan's Favor</para>
    /// <para>Effect of Titan's Favor ends upon execution of certain summoner actions.</para>
    /// <para>Earth Attunement Cost: 1</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// <para>※Precious Brilliance changes to Topaz Catastrophe when requirements for execution are met.</para>
    /// </summary>

    public IBaseAction TopazCatastrophePvE => _TopazCatastrophePvECreator.Value;
    private readonly Lazy<IBaseAction> _EmeraldCatastrophePvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25834, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyEmeraldCatastrophePvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25834"><strong>Emerald Catastrophe</strong></see> <i>PvE</i> (SMN) [25834] [Spell]
    /// </summary>
    static partial void ModifyEmeraldCatastrophePvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25834"><strong>Emerald Catastrophe</strong></see> <i>PvE</i> (SMN) [25834] [Spell]
    /// <para>Deals wind damage with a potency of 100 to target and all enemies nearby it.</para>
    /// <para>Wind Attunement Cost: 1</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// <para>※Precious Brilliance changes to Emerald Catastrophe when requirements for execution are met.</para>
    /// </summary>

    public IBaseAction EmeraldCatastrophePvE => _EmeraldCatastrophePvECreator.Value;
    private readonly Lazy<IBaseAction> _CrimsonCyclonePvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25835, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyCrimsonCyclonePvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25835"><strong>Crimson Cyclone</strong></see> <i>PvE</i> (SMN) [25835] [Spell]
    /// </summary>
    static partial void ModifyCrimsonCyclonePvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25835"><strong>Crimson Cyclone</strong></see> <i>PvE</i> (SMN) [25835] [Spell]
    /// <para>Rushes forward and delivers a fire attack to target and all enemies nearby it with a potency of  for the first enemy, and 65% less for all remaining enemies.</para>
    /// <para>Can only be executed while under the effect of Ifrit's Favor.</para>
    /// <para>Cannot be executed while bound.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// <para>※Astral Flow changes to Crimson Cyclone when requirements for execution are met.</para>
    /// </summary>

    public IBaseAction CrimsonCyclonePvE => _CrimsonCyclonePvECreator.Value;
    private readonly Lazy<IBaseAction> _MountainBusterPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25836, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyMountainBusterPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25836"><strong>Mountain Buster</strong></see> <i>PvE</i> (SMN) [25836] [Ability]
    /// </summary>
    static partial void ModifyMountainBusterPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25836"><strong>Mountain Buster</strong></see> <i>PvE</i> (SMN) [25836] [Ability]
    /// <para>Deals earth damage to target and all enemies nearby it with a potency of  for the first enemy, and 70% less for all remaining enemies.</para>
    /// <para>Can only be executed while under the effect of Titan's Favor.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// <para>※Astral Flow changes to Mountain Buster when requirements for execution are met.</para>
    /// </summary>

    public IBaseAction MountainBusterPvE => _MountainBusterPvECreator.Value;
    private readonly Lazy<IBaseAction> _SlipstreamPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25837, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifySlipstreamPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25837"><strong>Slipstream</strong></see> <i>PvE</i> (SMN) [25837] [Spell]
    /// </summary>
    static partial void ModifySlipstreamPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25837"><strong>Slipstream</strong></see> <i>PvE</i> (SMN) [25837] [Spell]
    /// <para>Deals wind damage to target and all enemies nearby it with a potency of  for the first enemy, and 65% less for all remaining enemies.</para>
    /// <para>Additional Effect: Creates a windstorm centered around the target, dealing damage to any enemies who enter</para>
    /// <para>Potency: 30</para>
    /// <para>Duration: 15s</para>
    /// <para>Can only be executed while under the effect of Garuda's Favor.</para>
    /// <para>This action does not share a recast timer with any other actions. Upon execution, the recast timer for this action will be applied to all other weaponskills and magic actions.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// <para>※Astral Flow changes to Slipstream when requirements for execution are met.</para>
    /// </summary>

    public IBaseAction SlipstreamPvE => _SlipstreamPvECreator.Value;
    private readonly Lazy<IBaseAction> _SummonIfritIiPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25838, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifySummonIfritIiPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25838"><strong>Summon Ifrit II</strong></see> <i>PvE</i> (SMN) [25838] [Spell]
    /// </summary>
    static partial void ModifySummonIfritIiPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25838"><strong>Summon Ifrit II</strong></see> <i>PvE</i> (SMN) [25838] [Spell]
    /// <para>Summons Ruby Ifrit and orders it to execute Inferno.</para>
    /// <para>Inferno Effect: Deals fire damage to target and all enemies within 5 yalms with a potency of  for the first enemy, and 60% less for all remaining enemies</para>
    /// <para>Additional Effect: Grants 2 stacks of Fire Attunement</para>
    /// <para>Duration: 30s</para>
    /// <para>Fire Attunement Effect: Gemshine and Precious Brilliance become fire-aspected</para>
    /// <para>Additional Effect: Grants Ifrit's Favor</para>
    /// <para>Effect of Ifrit's Favor ends upon execution of certain summoner actions.</para>
    /// <para>Can only be executed while under the effect of Ruby Arcanum and Carbuncle is summoned.</para>
    /// <para>Current pet will leave the battlefield while Ruby Ifrit is present, and return once gone.</para>
    /// </summary>

    public IBaseAction SummonIfritIiPvE => _SummonIfritIiPvECreator.Value;
    private readonly Lazy<IBaseAction> _SummonTitanIiPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25839, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifySummonTitanIiPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25839"><strong>Summon Titan II</strong></see> <i>PvE</i> (SMN) [25839] [Spell]
    /// </summary>
    static partial void ModifySummonTitanIiPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25839"><strong>Summon Titan II</strong></see> <i>PvE</i> (SMN) [25839] [Spell]
    /// <para>Summons Topaz Titan and orders it to execute Earthen Fury.</para>
    /// <para>Earthen Fury Effect: Deals earth damage to target and all enemies within 5 yalms with a potency of  for the first enemy, and 60% less for all remaining enemies</para>
    /// <para>Additional Effect: Grants 4 stacks of Earth Attunement</para>
    /// <para>Duration: 30s</para>
    /// <para>Earth Attunement Effect: Gemshine and Precious Brilliance become earth-aspected</para>
    /// <para>Can only be executed while under the effect of Topaz Arcanum and Carbuncle is summoned.</para>
    /// <para>Current pet will leave the battlefield while Topaz Titan is present, and return once gone.</para>
    /// </summary>

    public IBaseAction SummonTitanIiPvE => _SummonTitanIiPvECreator.Value;
    private readonly Lazy<IBaseAction> _SummonGarudaIiPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25840, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifySummonGarudaIiPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25840"><strong>Summon Garuda II</strong></see> <i>PvE</i> (SMN) [25840] [Spell]
    /// </summary>
    static partial void ModifySummonGarudaIiPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25840"><strong>Summon Garuda II</strong></see> <i>PvE</i> (SMN) [25840] [Spell]
    /// <para>Summons Emerald Garuda and orders it to execute Aerial Blast.</para>
    /// <para>Aerial Blast Effect: Deals wind damage to target and all enemies within 5 yalms with a potency of  for the first enemy, and 60% less for all remaining enemies</para>
    /// <para>Additional Effect: Grants 4 stacks of Wind Attunement</para>
    /// <para>Duration: 30s</para>
    /// <para>Wind Attunement Effect: Gemshine and Precious Brilliance become wind-aspected</para>
    /// <para>Additional Effect: Grants Garuda's Favor</para>
    /// <para>Effect of Garuda's Favor ends upon execution of certain summoner actions.</para>
    /// <para>Can only be executed while under the effect of Emerald Arcanum and Carbuncle is summoned.</para>
    /// <para>Current pet will leave the battlefield while Emerald Garuda is present, and return once gone.</para>
    /// </summary>

    public IBaseAction SummonGarudaIiPvE => _SummonGarudaIiPvECreator.Value;
    private readonly Lazy<IBaseAction> _RadiantAegisPvE_25841Creator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25841, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyRadiantAegisPvE_25841(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25841"><strong>Radiant Aegis</strong></see> <i>PvE</i> (ACN SMN) [25841] [Ability]
    /// </summary>
    static partial void ModifyRadiantAegisPvE_25841(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25841"><strong>Radiant Aegis</strong></see> <i>PvE</i> (ACN SMN) [25841] [Ability]
    /// <para>Creates a barrier around you that absorbs damage totaling 20% of your maximum HP.</para>
    /// <para>Duration: 30s</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction RadiantAegisPvE_25841 => _RadiantAegisPvE_25841Creator.Value;
    private readonly Lazy<IBaseAction> _GemshinePvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25883, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyGemshinePvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25883"><strong>Gemshine</strong></see> <i>PvE</i> (ACN SMN) [25883] [Spell]
    /// </summary>
    static partial void ModifyGemshinePvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25883"><strong>Gemshine</strong></see> <i>PvE</i> (ACN SMN) [25883] [Spell]
    /// <para>Channel the energies of your active elemental attunement to attack your enemy.</para>
    /// <para>Fire Attunement Effect: Deal fire damage to a single target</para>
    /// <para>Earth Attunement Effect: Deal earth damage to a single target</para>
    /// <para>Wind Attunement Effect: Deal wind damage to a single target</para>
    /// </summary>

    public IBaseAction GemshinePvE => _GemshinePvECreator.Value;
    private readonly Lazy<IBaseAction> _PreciousBrilliancePvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25884, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyPreciousBrilliancePvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25884"><strong>Precious Brilliance</strong></see> <i>PvE</i> (ACN SMN) [25884] [Spell]
    /// </summary>
    static partial void ModifyPreciousBrilliancePvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25884"><strong>Precious Brilliance</strong></see> <i>PvE</i> (ACN SMN) [25884] [Spell]
    /// <para>Channel the energies of your active elemental attunement to attack multiple enemies.</para>
    /// <para>Fire Attunement Effect: Deal fire damage to a target and all enemies nearby it</para>
    /// <para>Earth Attunement Effect: Deal earth damage to a target and all enemies nearby it</para>
    /// <para>Wind Attunement Effect: Deal wind damage to a target and all enemies nearby it</para>
    /// </summary>

    public IBaseAction PreciousBrilliancePvE => _PreciousBrilliancePvECreator.Value;
    private readonly Lazy<IBaseAction> _CrimsonStrikePvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)25885, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyCrimsonStrikePvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/25885"><strong>Crimson Strike</strong></see> <i>PvE</i> (SMN) [25885] [Spell]
    /// </summary>
    static partial void ModifyCrimsonStrikePvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/25885"><strong>Crimson Strike</strong></see> <i>PvE</i> (SMN) [25885] [Spell]
    /// <para>Deals fire damage to target and all enemies nearby it with a potency of  for the first enemy, and 65% less for all remaining enemies.</para>
    /// <para>Combo Action: Crimson Cyclone</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// <para>※Crimson Cyclone changes to Crimson Strike when requirements for execution are met.</para>
    /// </summary>

    public IBaseAction CrimsonStrikePvE => _CrimsonStrikePvECreator.Value;
    private readonly Lazy<IBaseAction> _RuinIiiPvPCreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)29664, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyRuinIiiPvP(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/29664"><strong>Ruin III</strong></see> <i>PvP</i> (SMN) [29664] [Spell]
    /// </summary>
    static partial void ModifyRuinIiiPvP(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/29664"><strong>Ruin III</strong></see> <i>PvP</i> (SMN) [29664] [Spell]
    /// <para>Deals unaspected damage with a potency of 5,000.</para>
    /// <para></para>
    /// <para>※Action changes to Astral Impulse while under the effect of Dreadwyrm Trance.</para>
    /// <para>※Action changes to Fountain of Fire while under the effect of Firebird Trance.</para>
    /// </summary>

    public IBaseAction RuinIiiPvP => _RuinIiiPvPCreator.Value;
    private readonly Lazy<IBaseAction> _AstralImpulsePvPCreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)29665, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyAstralImpulsePvP(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/29665"><strong>Astral Impulse</strong></see> <i>PvP</i> (SMN) [29665] [Spell]
    /// </summary>
    static partial void ModifyAstralImpulsePvP(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/29665"><strong>Astral Impulse</strong></see> <i>PvP</i> (SMN) [29665] [Spell]
    /// <para>Deals unaspected damage with a potency of 7,500.</para>
    /// <para>Can only be executed while under the effect of Dreadwyrm Trance.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction AstralImpulsePvP => _AstralImpulsePvPCreator.Value;
    private readonly Lazy<IBaseAction> _FountainOfFirePvPCreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)29666, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyFountainOfFirePvP(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/29666"><strong>Fountain of Fire</strong></see> <i>PvP</i> (SMN) [29666] [Spell]
    /// </summary>
    static partial void ModifyFountainOfFirePvP(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/29666"><strong>Fountain of Fire</strong></see> <i>PvP</i> (SMN) [29666] [Spell]
    /// <para>Deals fire damage with a potency of 5,000.</para>
    /// <para>Can only be executed while under the effect of Firebird Trance.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction FountainOfFirePvP => _FountainOfFirePvPCreator.Value;
    private readonly Lazy<IBaseAction> _CrimsonCyclonePvPCreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)29667, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyCrimsonCyclonePvP(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/29667"><strong>Crimson Cyclone</strong></see> <i>PvP</i> (SMN) [29667] [Spell]
    /// </summary>
    static partial void ModifyCrimsonCyclonePvP(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/29667"><strong>Crimson Cyclone</strong></see> <i>PvP</i> (SMN) [29667] [Spell]
    /// <para>Rushes forward and delivers a fire attack with a potency of 8,000 to target and all enemies nearby it.</para>
    /// <para>Cannot be executed while bound.</para>
    /// <para>This action does not share a recast timer with any other actions.</para>
    /// <para></para>
    /// <para>※Action changes to Crimson Strike upon execution.</para>
    /// </summary>

    public IBaseAction CrimsonCyclonePvP => _CrimsonCyclonePvPCreator.Value;
    private readonly Lazy<IBaseAction> _CrimsonStrikePvPCreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)29668, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyCrimsonStrikePvP(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/29668"><strong>Crimson Strike</strong></see> <i>PvP</i> (SMN) [29668] [Spell]
    /// </summary>
    static partial void ModifyCrimsonStrikePvP(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/29668"><strong>Crimson Strike</strong></see> <i>PvP</i> (SMN) [29668] [Spell]
    /// <para>Deals fire damage with a potency of 12,000 to target and all enemies nearby it.</para>
    /// <para>Combo Action: Crimson Cyclone</para>
    /// <para>Additional Effect: 5-yalm knockback emanating from first target</para>
    /// <para>This action does not share a recast timer with any other actions.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction CrimsonStrikePvP => _CrimsonStrikePvPCreator.Value;
    private readonly Lazy<IBaseAction> _SlipstreamPvPCreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)29669, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifySlipstreamPvP(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/29669"><strong>Slipstream</strong></see> <i>PvP</i> (SMN) [29669] [Spell]
    /// </summary>
    static partial void ModifySlipstreamPvP(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/29669"><strong>Slipstream</strong></see> <i>PvP</i> (SMN) [29669] [Spell]
    /// <para>Deals wind damage with a potency of 8,000 to target and all enemies nearby it.</para>
    /// <para>Additional Effect: Creates a Slipstream centered around target, dealing damage to any enemies who enter</para>
    /// <para>Enemies standing within 5 yalms of the storm's eye take no damage.</para>
    /// <para>Potency: 4,000</para>
    /// <para>Additional Effect: Increases movement speed of party members standing in the Slipstream by 25%</para>
    /// <para>Duration: 10s</para>
    /// <para>This action does not share a recast timer with any other actions.</para>
    /// </summary>

    public IBaseAction SlipstreamPvP => _SlipstreamPvPCreator.Value;
    private readonly Lazy<IBaseAction> _RadiantAegisPvPCreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)29670, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyRadiantAegisPvP(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/29670"><strong>Radiant Aegis</strong></see> <i>PvP</i> (SMN) [29670] [Ability]
    /// </summary>
    static partial void ModifyRadiantAegisPvP(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/29670"><strong>Radiant Aegis</strong></see> <i>PvP</i> (SMN) [29670] [Ability]
    /// <para>Creates a barrier around self or target party member that reduces damage taken by 20% and absorbs damage equivalent to a heal of 10,000 potency.</para>
    /// <para>Duration: 10s</para>
    /// </summary>

    public IBaseAction RadiantAegisPvP => _RadiantAegisPvPCreator.Value;
    private readonly Lazy<IBaseAction> _MountainBusterPvPCreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)29671, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyMountainBusterPvP(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/29671"><strong>Mountain Buster</strong></see> <i>PvP</i> (SMN) [29671] [Ability]
    /// </summary>
    static partial void ModifyMountainBusterPvP(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/29671"><strong>Mountain Buster</strong></see> <i>PvP</i> (SMN) [29671] [Ability]
    /// <para>Deals earth damage with a potency of 4,000 to target and all enemies nearby it.</para>
    /// <para>Additional Effect: Afflicts first target with Bind, and all remaining targets with Heavy +75%</para>
    /// <para>Duration: 3s</para>
    /// <para>Additional Effect: Draws remaining targets in toward first target</para>
    /// </summary>

    public IBaseAction MountainBusterPvP => _MountainBusterPvPCreator.Value;
    private readonly Lazy<IBaseAction> _FesterPvPCreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)29672, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyFesterPvP(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/29672"><strong>Fester</strong></see> <i>PvP</i> (SMN) [29672] [Ability]
    /// </summary>
    static partial void ModifyFesterPvP(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/29672"><strong>Fester</strong></see> <i>PvP</i> (SMN) [29672] [Ability]
    /// <para>Deals unaspected damage with a potency of 4,000.</para>
    /// <para>Potency increases up to 8,000 as the target's HP decreases, reaching its maximum value when the target has 50% HP or less.</para>
    /// <para>Maximum Charges: 2</para>
    /// </summary>

    public IBaseAction FesterPvP => _FesterPvPCreator.Value;
    private readonly Lazy<IBaseAction> _EnkindleBahamutPvPCreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)29674, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyEnkindleBahamutPvP(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/29674"><strong>Enkindle Bahamut</strong></see> <i>PvP</i> (SMN) [29674] [Ability]
    /// </summary>
    static partial void ModifyEnkindleBahamutPvP(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/29674"><strong>Enkindle Bahamut</strong></see> <i>PvP</i> (SMN) [29674] [Ability]
    /// <para>Orders Demi-Bahamut to execute Akh Morn.</para>
    /// <para>Akh Morn Effect: Deals unaspected damage with a potency of 12,000 to target and all enemies nearby it.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction EnkindleBahamutPvP => _EnkindleBahamutPvPCreator.Value;
    private readonly Lazy<IBaseAction> _MegaflarePvPCreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)29675, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyMegaflarePvP(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/29675"><strong>Megaflare</strong></see> <i>PvP</i> (SMN) [29675] [Ability]
    /// </summary>
    static partial void ModifyMegaflarePvP(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/29675"><strong>Megaflare</strong></see> <i>PvP</i> (SMN) [29675] [Ability]
    /// <para>Deals unaspected damage with a potency of 18,000 to all nearby enemies.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction MegaflarePvP => _MegaflarePvPCreator.Value;
    private readonly Lazy<IBaseAction> _WyrmwavePvPCreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)29676, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyWyrmwavePvP(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/29676"><strong>Wyrmwave</strong></see> <i>PvP</i> (SMN) [29676] [Spell]
    /// </summary>
    static partial void ModifyWyrmwavePvP(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/29676"><strong>Wyrmwave</strong></see> <i>PvP</i> (SMN) [29676] [Spell]
    /// <para>Deals unaspected damage with a potency of 6,000.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction WyrmwavePvP => _WyrmwavePvPCreator.Value;
    private readonly Lazy<IBaseAction> _AkhMornPvPCreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)29677, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyAkhMornPvP(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/29677"><strong>Akh Morn</strong></see> <i>PvP</i> (SMN) [29677] [Ability]
    /// </summary>
    static partial void ModifyAkhMornPvP(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/29677"><strong>Akh Morn</strong></see> <i>PvP</i> (SMN) [29677] [Ability]
    /// <para>Deals unaspected damage with a potency of 12,000 to target and all enemies nearby it.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction AkhMornPvP => _AkhMornPvPCreator.Value;
    private readonly Lazy<IBaseAction> _EnkindlePhoenixPvPCreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)29679, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyEnkindlePhoenixPvP(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/29679"><strong>Enkindle Phoenix</strong></see> <i>PvP</i> (SMN) [29679] [Ability]
    /// </summary>
    static partial void ModifyEnkindlePhoenixPvP(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/29679"><strong>Enkindle Phoenix</strong></see> <i>PvP</i> (SMN) [29679] [Ability]
    /// <para>Orders Demi-Phoenix to execute Revelation.</para>
    /// <para>Revelation Effect: Deals unaspected damage with a potency of 6,000 to target and all enemies nearby it</para>
    /// <para>Additional Effect: Damage over time</para>
    /// <para>Potency: 3,000</para>
    /// <para>Duration: 15s</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction EnkindlePhoenixPvP => _EnkindlePhoenixPvPCreator.Value;
    private readonly Lazy<IBaseAction> _EverlastingFlightPvPCreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)29680, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyEverlastingFlightPvP(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/29680"><strong>Everlasting Flight</strong></see> <i>PvP</i> (SMN) [29680] [Ability]
    /// </summary>
    static partial void ModifyEverlastingFlightPvP(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/29680"><strong>Everlasting Flight</strong></see> <i>PvP</i> (SMN) [29680] [Ability]
    /// <para>Gradually restores own HP and the HP of all nearby party members.</para>
    /// <para>Cure Potency: 4,000</para>
    /// <para>Duration: 15s</para>
    /// <para>Additional Effect: Restores HP when HP falls below 25% or upon effect duration expiration</para>
    /// <para>Cure Potency: 12,000</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction EverlastingFlightPvP => _EverlastingFlightPvPCreator.Value;
    private readonly Lazy<IBaseAction> _ScarletFlamePvPCreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)29681, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyScarletFlamePvP(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/29681"><strong>Scarlet Flame</strong></see> <i>PvP</i> (SMN) [29681] [Spell]
    /// </summary>
    static partial void ModifyScarletFlamePvP(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/29681"><strong>Scarlet Flame</strong></see> <i>PvP</i> (SMN) [29681] [Spell]
    /// <para>Deals fire damage with a potency of 4,000.</para>
    /// <para>Additional Effect: Reduces target's damage dealt by 50%</para>
    /// <para>Duration: 5s</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction ScarletFlamePvP => _ScarletFlamePvPCreator.Value;
    private readonly Lazy<IBaseAction> _RevelationPvPCreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)29682, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyRevelationPvP(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/29682"><strong>Revelation</strong></see> <i>PvP</i> (SMN) [29682] [Ability]
    /// </summary>
    static partial void ModifyRevelationPvP(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/29682"><strong>Revelation</strong></see> <i>PvP</i> (SMN) [29682] [Ability]
    /// <para>Deals unaspected damage with a potency of 6,000 to target and all enemies nearby it.</para>
    /// <para>Additional Effect: Damage over time</para>
    /// <para>Potency: 3,000</para>
    /// <para>Duration: 15s</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction RevelationPvP => _RevelationPvPCreator.Value;
    private readonly Lazy<IBaseAction> _NecrotizePvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)36990, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyNecrotizePvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/36990"><strong>Necrotize</strong></see> <i>PvE</i> (SMN) [36990] [Ability]
    /// </summary>
    static partial void ModifyNecrotizePvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/36990"><strong>Necrotize</strong></see> <i>PvE</i> (SMN) [36990] [Ability]
    /// <para>Deals unaspected damage with a potency of 420.</para>
    /// <para>Aetherflow Gauge Cost: 1</para>
    /// </summary>

    public IBaseAction NecrotizePvE => _NecrotizePvECreator.Value;
    private readonly Lazy<IBaseAction> _SearingFlashPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)36991, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifySearingFlashPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/36991"><strong>Searing Flash</strong></see> <i>PvE</i> (SMN) [36991] [Ability]
    /// </summary>
    static partial void ModifySearingFlashPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/36991"><strong>Searing Flash</strong></see> <i>PvE</i> (SMN) [36991] [Ability]
    /// <para>Deals unaspected damage with a potency of 600 to target and all enemies nearby it.</para>
    /// <para>Can only be executed while under the effect of Ruby's Glimmer.</para>
    /// </summary>

    public IBaseAction SearingFlashPvE => _SearingFlashPvECreator.Value;
    private readonly Lazy<IBaseAction> _SummonSolarBahamutPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)36992, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifySummonSolarBahamutPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/36992"><strong>Summon Solar Bahamut</strong></see> <i>PvE</i> (SMN) [36992] [Spell]
    /// </summary>
    static partial void ModifySummonSolarBahamutPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/36992"><strong>Summon Solar Bahamut</strong></see> <i>PvE</i> (SMN) [36992] [Spell]
    /// <para>Enters Lightwyrm Trance and summons Solar Bahamut to fight your target.</para>
    /// <para>Solar Bahamut will execute Luxwave automatically on the targets attacked by you after summoning.</para>
    /// <para>Increases enmity in target when Solar Bahamut is summoned.</para>
    /// <para>Duration: 15s</para>
    /// <para>Additional Effect: Grants Refulgent Lux</para>
    /// <para>Duration: 30s</para>
    /// <para>Additional Effect: Changes Ruin III to Umbral Impulse and Tri-disaster to Umbral Flare</para>
    /// <para>Additional Effect: Grants Ruby Arcanum, Topaz Arcanum, and Emerald Arcanum</para>
    /// <para>Can only be executed while Carbuncle is summoned.</para>
    /// <para>This action does not share a recast timer with any other actions.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// <para>※Summon Bahamut changes to Summon Solar Bahamut when requirements for execution are met.</para>
    /// </summary>

    public IBaseAction SummonSolarBahamutPvE => _SummonSolarBahamutPvECreator.Value;
    private readonly Lazy<IBaseAction> _LuxwavePvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)36993, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyLuxwavePvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/36993"><strong>Luxwave</strong></see> <i>PvE</i> (SMN) [36993] [Spell]
    /// </summary>
    static partial void ModifyLuxwavePvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/36993"><strong>Luxwave</strong></see> <i>PvE</i> (SMN) [36993] [Spell]
    /// <para>Deals unaspected damage with a potency of 160.</para>
    /// <para>Will only execute while Solar Bahamut is summoned.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction LuxwavePvE => _LuxwavePvECreator.Value;
    private readonly Lazy<IBaseAction> _UmbralImpulsePvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)36994, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyUmbralImpulsePvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/36994"><strong>Umbral Impulse</strong></see> <i>PvE</i> (SMN) [36994] [Spell]
    /// </summary>
    static partial void ModifyUmbralImpulsePvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/36994"><strong>Umbral Impulse</strong></see> <i>PvE</i> (SMN) [36994] [Spell]
    /// <para>Deals unaspected damage with a potency of 600.</para>
    /// <para>Can only be executed while in Lightwyrm Trance.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// <para>※Ruin III changes to Umbral Impulse when requirements for execution are met.</para>
    /// </summary>

    public IBaseAction UmbralImpulsePvE => _UmbralImpulsePvECreator.Value;
    private readonly Lazy<IBaseAction> _UmbralFlarePvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)36995, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyUmbralFlarePvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/36995"><strong>Umbral Flare</strong></see> <i>PvE</i> (SMN) [36995] [Spell]
    /// </summary>
    static partial void ModifyUmbralFlarePvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/36995"><strong>Umbral Flare</strong></see> <i>PvE</i> (SMN) [36995] [Spell]
    /// <para>Deals unaspected damage with a potency of 280 to target and all enemies nearby it.</para>
    /// <para>Can only be executed while in Lightwyrm Trance.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// <para>※Tri-disaster changes to Umbral Flare when requirements for execution are met.</para>
    /// </summary>

    public IBaseAction UmbralFlarePvE => _UmbralFlarePvECreator.Value;
    private readonly Lazy<IBaseAction> _SunflarePvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)36996, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifySunflarePvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/36996"><strong>Sunflare</strong></see> <i>PvE</i> (SMN) [36996] [Ability]
    /// </summary>
    static partial void ModifySunflarePvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/36996"><strong>Sunflare</strong></see> <i>PvE</i> (SMN) [36996] [Ability]
    /// <para>Deals unaspected damage to target and all enemies nearby it with a potency of 600 for the first enemy, and 60% less for all remaining enemies.</para>
    /// <para>Can only be executed while in Lightwyrm Trance.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// <para>※Astral Flow changes to Sunflare when requirements for execution are met.</para>
    /// </summary>

    public IBaseAction SunflarePvE => _SunflarePvECreator.Value;
    private readonly Lazy<IBaseAction> _LuxSolarisPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)36997, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyLuxSolarisPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/36997"><strong>Lux Solaris</strong></see> <i>PvE</i> (SMN) [36997] [Ability]
    /// </summary>
    static partial void ModifyLuxSolarisPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/36997"><strong>Lux Solaris</strong></see> <i>PvE</i> (SMN) [36997] [Ability]
    /// <para>Restores own HP and the HP of all nearby party members.</para>
    /// <para>Cure Potency: 500</para>
    /// <para>Can only be executed while under the effect of Refulgent Lux.</para>
    /// </summary>

    public IBaseAction LuxSolarisPvE => _LuxSolarisPvECreator.Value;
    private readonly Lazy<IBaseAction> _EnkindleSolarBahamutPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)36998, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyEnkindleSolarBahamutPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/36998"><strong>Enkindle Solar Bahamut</strong></see> <i>PvE</i> (SMN) [36998] [Ability]
    /// </summary>
    static partial void ModifyEnkindleSolarBahamutPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/36998"><strong>Enkindle Solar Bahamut</strong></see> <i>PvE</i> (SMN) [36998] [Ability]
    /// <para>Orders Solar Bahamut to execute Exodus.</para>
    /// <para>Exodus Effect: Deals unaspected damage to target and all enemies nearby it with a potency of 1,400 for the first enemy, and 60% less for all remaining enemies</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// <para>※Enkindle Bahamut changes to Enkindle Solar Bahamut when requirements for execution are met.</para>
    /// </summary>

    public IBaseAction EnkindleSolarBahamutPvE => _EnkindleSolarBahamutPvECreator.Value;
    private readonly Lazy<IBaseAction> _ExodusPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)36999, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifyExodusPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/36999"><strong>Exodus</strong></see> <i>PvE</i> (SMN) [36999] [Ability]
    /// </summary>
    static partial void ModifyExodusPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/36999"><strong>Exodus</strong></see> <i>PvE</i> (SMN) [36999] [Ability]
    /// <para>Deals unaspected damage to target and all enemies nearby it with a potency of 1,400 for the first enemy, and 60% less for all remaining enemies.</para>
    /// <para>Can only be executed while Solar Bahamut is summoned.</para>
    /// <para></para>
    /// <para>※This action cannot be assigned to a hotbar.</para>
    /// </summary>

    public IBaseAction ExodusPvE => _ExodusPvECreator.Value;

    private IBaseAction[] _AllBaseActions = null;

    /// <inheritdoc/>
    public override IBaseAction[] AllBaseActions => _AllBaseActions ??= [
        RuinPvE, RuinIiPvE, ResurrectionPvE, FesterPvE, PainflarePvE, RuinIiiPvE, DreadwyrmTrancePvE, DeathflarePvE, RuinIvPvE, SummonBahamutPvE, WyrmwavePvE, EnkindleBahamutPvE, AkhMornPvE, PhysickPvE, EnergyDrainPvE, EnergySiphonPvE, OutburstPvE, FountainOfFirePvE, BrandOfPurgatoryPvE, EnkindlePhoenixPvE, EverlastingFlightPvE, RevelationPvE, ScarletFlamePvE, SummonCarbunclePvE, RadiantAegisPvE, AetherchargePvE, SearingLightPvE, SummonRubyPvE, SummonTopazPvE, SummonEmeraldPvE, SummonIfritPvE, SummonTitanPvE, SummonGarudaPvE, RubyRuinPvE, TopazRuinPvE, EmeraldRuinPvE, RubyRuinIiPvE, TopazRuinIiPvE, EmeraldRuinIiPvE, RubyOutburstPvE, TopazOutburstPvE, EmeraldOutburstPvE, RubyRuinIiiPvE, TopazRuinIiiPvE, EmeraldRuinIiiPvE, AstralImpulsePvE, AstralFlarePvE, AstralFlowPvE, RubyRitePvE, TopazRitePvE, EmeraldRitePvE, TridisasterPvE, RubyDisasterPvE, TopazDisasterPvE, EmeraldDisasterPvE, RekindlePvE, SummonPhoenixPvE, RubyCatastrophePvE, TopazCatastrophePvE, EmeraldCatastrophePvE, CrimsonCyclonePvE, MountainBusterPvE, SlipstreamPvE, SummonIfritIiPvE, SummonTitanIiPvE, SummonGarudaIiPvE, GemshinePvE, PreciousBrilliancePvE, CrimsonStrikePvE, RuinIiiPvP, AstralImpulsePvP, FountainOfFirePvP, CrimsonCyclonePvP, CrimsonStrikePvP, SlipstreamPvP, RadiantAegisPvP, MountainBusterPvP, FesterPvP, EnkindleBahamutPvP, MegaflarePvP, WyrmwavePvP, AkhMornPvP, EnkindlePhoenixPvP, EverlastingFlightPvP, ScarletFlamePvP, RevelationPvP, NecrotizePvE, SearingFlashPvE, SummonSolarBahamutPvE, LuxwavePvE, UmbralImpulsePvE, UmbralFlarePvE, SunflarePvE, LuxSolarisPvE, EnkindleSolarBahamutPvE, ExodusPvE,
    ..base.AllBaseActions,
];



    private readonly Lazy<IBaseAction> _SkyshardPvECreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)203, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifySkyshardPvE(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/203"><strong>Skyshard</strong></see> <i>PvE</i> (All Classes) [203] [Limit Break]
    /// </summary>
    static partial void ModifySkyshardPvE(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/203"><strong>Skyshard</strong></see> <i>PvE</i> (All Classes) [203] [Limit Break]
    /// <para>Deals unaspected damage with a potency of 1,650 to all enemies near point of impact.</para>
    /// </summary>

    public IBaseAction SkyshardPvE => _SkyshardPvECreator.Value;
    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/203"><strong>Skyshard</strong></see> <i>PvE</i> (All Classes) [203] [Limit Break]
    /// <para>Deals unaspected damage with a potency of 1,650 to all enemies near point of impact.</para>
    /// </summary>
    private sealed protected override IBaseAction LimitBreak3 => SkyshardPvE;
    private readonly Lazy<IBaseAction> _SummonBahamutPvPCreator = new(() =>
    {
        IBaseAction action = new BaseAction((ActionID)29673, false);
        CustomRotation.LoadActionSetting(ref action);

        var setting = action.Setting;
        ModifySummonBahamutPvP(ref setting);
        action.Setting = setting;

        return action;
    });

    /// <summary>
    /// Modify <see href="https://garlandtools.org/db/#action/29673"><strong>Summon Bahamut</strong></see> <i>PvP</i> (SMN) [29673] [Limit Break]
    /// </summary>
    static partial void ModifySummonBahamutPvP(ref ActionSetting setting);

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/29673"><strong>Summon Bahamut</strong></see> <i>PvP</i> (SMN) [29673] [Limit Break]
    /// <para>Enters Dreadwyrm Trance and summons Demi-Bahamut to fight at a designated location.</para>
    /// <para>Duration: 20s</para>
    /// <para>Demi-Bahamut will execute Megaflare upon being summoned, then execute Wyrmwave automatically, prioritizing targets with the lowest HP within 30 yalms.</para>
    /// <para>Can only be executed when the limit gauge is full.</para>
    /// <para>Gauge Charge Time: 90s</para>
    /// <para></para>
    /// <para>※Action changes to Enkindle Bahamut upon execution.</para>
    /// <para>※Ruin III changes to Astral Impulse while under the effect of Dreadwyrm Trance.</para>
    /// </summary>

    private IBaseAction SummonBahamutPvP => _SummonBahamutPvPCreator.Value;
    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/29673"><strong>Summon Bahamut</strong></see> <i>PvP</i> (SMN) [29673] [Limit Break]
    /// <para>Enters Dreadwyrm Trance and summons Demi-Bahamut to fight at a designated location.</para>
    /// <para>Duration: 20s</para>
    /// <para>Demi-Bahamut will execute Megaflare upon being summoned, then execute Wyrmwave automatically, prioritizing targets with the lowest HP within 30 yalms.</para>
    /// <para>Can only be executed when the limit gauge is full.</para>
    /// <para>Gauge Charge Time: 90s</para>
    /// <para></para>
    /// <para>※Action changes to Enkindle Bahamut upon execution.</para>
    /// <para>※Ruin III changes to Astral Impulse while under the effect of Dreadwyrm Trance.</para>
    /// </summary>
    private sealed protected override IBaseAction LimitBreakPvP => SummonBahamutPvP;

    #endregion

    #region Traits

    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/50178"><strong>Enhanced Dreadwyrm Trance</strong></see> [178]
    /// <para>Upgrades Dreadwyrm Trance to Summon Bahamut.</para>
    /// </summary>
    public static IBaseTrait EnhancedDreadwyrmTranceTrait { get; } = new BaseTrait(178);
    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/50468"><strong>Ruby Summoning Mastery</strong></see> [468]
    /// <para>Upgrades Summon Ruby to Summon Ifrit.</para>
    /// </summary>
    public static IBaseTrait RubySummoningMasteryTrait { get; } = new BaseTrait(468);
    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/50469"><strong>Topaz Summoning Mastery</strong></see> [469]
    /// <para>Upgrades Summon Topaz to Summon Titan.</para>
    /// </summary>
    public static IBaseTrait TopazSummoningMasteryTrait { get; } = new BaseTrait(469);
    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/50470"><strong>Emerald Summoning Mastery</strong></see> [470]
    /// <para>Upgrades Summon Emerald to Summon Garuda.</para>
    /// </summary>
    public static IBaseTrait EmeraldSummoningMasteryTrait { get; } = new BaseTrait(470);
    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/50471"><strong>Enkindle</strong></see> [471]
    /// <para>Enhances the signature attack of summons, upgrading Ifrit-Egi's Burning Strike to Inferno, Titan-Egi's Rock Buster to Earthen Fury, and Garuda-Egi's Aerial Slash to Aerial Blast.</para>
    /// </summary>
    public static IBaseTrait EnkindleTrait { get; } = new BaseTrait(471);
    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/50473"><strong>Ruin Mastery II</strong></see> [473]
    /// <para>Upgrades Ruin II to Ruin III.</para>
    /// </summary>
    public static IBaseTrait RuinMasteryIiTrait { get; } = new BaseTrait(473);
    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/50474"><strong>Aethercharge Mastery</strong></see> [474]
    /// <para>Upgrades Aethercharge to Dreadwyrm Trance.</para>
    /// </summary>
    public static IBaseTrait AetherchargeMasteryTrait { get; } = new BaseTrait(474);
    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/50475"><strong>Enhanced Energy Siphon</strong></see> [475]
    /// <para>Grants Further Ruin upon executing Energy Drain or Energy Siphon.</para>
    /// </summary>
    public static IBaseTrait EnhancedEnergySiphonTrait { get; } = new BaseTrait(475);
    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/50476"><strong>Ruin Mastery III</strong></see> [476]
    /// <para>Enhances Gemshine according to your current elemental attunement.</para>
    /// <para>Fire Attunement Upgrade: Ruby Rite</para>
    /// <para>Earth Attunement Upgrade: Topaz Rite</para>
    /// <para>Wind Attunement Upgrade: Emerald Rite</para>
    /// </summary>
    public static IBaseTrait RuinMasteryIiiTrait { get; } = new BaseTrait(476);
    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/50477"><strong>Outburst Mastery</strong></see> [477]
    /// <para>Upgrades Outburst to Tri-disaster.</para>
    /// </summary>
    public static IBaseTrait OutburstMasteryTrait { get; } = new BaseTrait(477);
    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/50478"><strong>Outburst Mastery II</strong></see> [478]
    /// <para>Enhances Precious Brilliance according to your current elemental attunement.</para>
    /// <para>Fire Attunement Upgrade: Ruby Catastrophe</para>
    /// <para>Earth Attunement Upgrade: Topaz Catastrophe</para>
    /// <para>Wind Attunement Upgrade: Emerald Catastrophe</para>
    /// </summary>
    public static IBaseTrait OutburstMasteryIiTrait { get; } = new BaseTrait(478);
    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/50479"><strong>Ruin Mastery IV</strong></see> [479]
    /// <para>Increases the potency of Ruin III to 310, Ruby Rite to 510, Topaz Rite to 330, and Emerald Rite to 230.</para>
    /// </summary>
    public static IBaseTrait RuinMasteryIvTrait { get; } = new BaseTrait(479);
    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/50480"><strong>Enhanced Radiant Aegis</strong></see> [480]
    /// <para>Allows the accumulation of charges for consecutive uses of Radiant Aegis.</para>
    /// <para>Maximum Charges: 2</para>
    /// </summary>
    public static IBaseTrait EnhancedRadiantAegisTrait { get; } = new BaseTrait(480);
    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/50481"><strong>Enkindle II</strong></see> [481]
    /// <para>Upgrades Summon Ifrit to Summon Ifrit II, Summon Titan to Summon Titan II, and Summon Garuda to Summon Garuda II.</para>
    /// </summary>
    public static IBaseTrait EnkindleIiTrait { get; } = new BaseTrait(481);
    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/50502"><strong>Enhanced Summon Bahamut</strong></see> [502]
    /// <para>Upgrades Summon Bahamut to Summon Phoenix when Demi-Bahamut returns from summoning.</para>
    /// </summary>
    public static IBaseTrait EnhancedSummonBahamutTrait { get; } = new BaseTrait(502);
    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/50503"><strong>Elemental Mastery</strong></see> [503]
    /// <para>Grants Ifrit's Favor upon executing Summon Ifrit, Titan's Favor upon executing Topaz Rite or Topaz Catastrophe, and Garuda's Favor upon executing Summon Garuda.</para>
    /// <para>Enhances Astral Flow according to your current elemental favor.</para>
    /// <para>Ifrit's Favor Upgrade: Crimson Cyclone</para>
    /// <para>Titan's Favor Upgrade: Mountain Buster</para>
    /// <para>Garuda's Favor Upgrade: Slipstream</para>
    /// </summary>
    public static IBaseTrait ElementalMasteryTrait { get; } = new BaseTrait(503);
    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/50617"><strong>Enhanced Fester</strong></see> [617]
    /// <para>Upgrades Fester to Necrotize.</para>
    /// </summary>
    public static IBaseTrait EnhancedFesterTrait { get; } = new BaseTrait(617);
    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/50618"><strong>Enhanced Searing Light</strong></see> [618]
    /// <para>Grants Ruby's Glimmer after executing Searing Light.</para>
    /// <para>Duration: 30s</para>
    /// </summary>
    public static IBaseTrait EnhancedSearingLightTrait { get; } = new BaseTrait(618);
    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/50619"><strong>Enhanced Summon Bahamut II</strong></see> [619]
    /// <para>Allows the summoning of Solar Bahamut in addition to Demi-Phoenix and Demi-Bahamut.</para>
    /// </summary>
    public static IBaseTrait EnhancedSummonBahamutIiTrait { get; } = new BaseTrait(619);
    /// <summary>
    /// <see href="https://garlandtools.org/db/#action/50664"><strong>Arcane Mastery</strong></see> [664]
    /// <para>Increases the potency of Ruin III to 360, Astral Impulse to 500, Ruin IV to 490, Ruby Rite to 540, Topaz Rite to 340, Emerald Rite to 240, Fountain of Fire to 580, Crimson Strike to 490, Crimson Cyclone to 490, Mountain Buster to 160, Slipstream to 490, Inferno to 800, Earthen Fury to 800, and Aerial Blast to 800.</para>
    /// </summary>
    public static IBaseTrait ArcaneMasteryTrait { get; } = new BaseTrait(664);

    private IBaseTrait[] _AllTraits = null;

    /// <inheritdoc/>
    public override IBaseTrait[] AllTraits => _AllTraits ??= [
        EnhancedDreadwyrmTranceTrait, RubySummoningMasteryTrait, TopazSummoningMasteryTrait, EmeraldSummoningMasteryTrait, EnkindleTrait, RuinMasteryIiTrait, AetherchargeMasteryTrait, EnhancedEnergySiphonTrait, RuinMasteryIiiTrait, OutburstMasteryTrait, OutburstMasteryIiTrait, RuinMasteryIvTrait, EnhancedRadiantAegisTrait, EnkindleIiTrait, EnhancedSummonBahamutTrait, ElementalMasteryTrait, EnhancedFesterTrait, EnhancedSearingLightTrait, EnhancedSummonBahamutIiTrait, ArcaneMasteryTrait,
    ..base.AllTraits,
    ];
    #endregion


}

