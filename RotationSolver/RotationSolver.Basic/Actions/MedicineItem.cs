﻿using Lumina.Excel.GeneratedSheets;

namespace RotationSolver.Basic.Actions;

/// <summary>
/// The type of the medicine
/// </summary>
public enum MedicineType : byte
{
    /// <summary>
    /// 
    /// </summary>
    None,

    /// <summary>
    /// 
    /// </summary>
    Strength,

    /// <summary>
    /// 
    /// </summary>
    Dexterity,

    /// <summary>
    /// 
    /// </summary>
    Vitality,

    /// <summary>
    /// 
    /// </summary>
    Intelligence,

    /// <summary>
    /// 
    /// </summary>
    Mind,
}

internal class MedicineItem : BaseItem
{
    public MedicineType Type { get; }

    public MedicineItem(Item item) : base(item)
    {
         Type = _item.Unknown19 switch
         {
             10120 => MedicineType.Strength,
             10140 => MedicineType.Dexterity,
             10160 => MedicineType.Vitality,
             10180 => MedicineType.Intelligence,
             10200 => MedicineType.Mind,
             _ => MedicineType.None,
         };
    }

    protected override bool CanUseThis => Service.Config.UseTinctures;
}
