using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.WPF.Reflection.Attributes;

namespace WastedLoot;

public class Settings
{
    [MaintainOrder]
    [Tooltip("The global chance that loot will NOT spawn in a container or in the world. In other words: higher number means less items.")]
    public short GlobalLootChanceNone = 60;
    
    [MaintainOrder]
    [Tooltip("Remove placed items in the world based on the Global Loot Chance None. Quest and other important items are not removed.")]
    public bool PatchWorldLoot = true;
    
    [MaintainOrder]
    [Tooltip("Remove placed misc items (junk).")]
    public bool RemoveMiscItems = true;
    
    [MaintainOrder]
    [Tooltip("Remove placed weapons.")]
    public bool RemoveWeapons = true;
    
    [MaintainOrder]
    [Tooltip("Remove placed ammo.")]
    public bool RemoveAmmo = true;
    
    [MaintainOrder]
    [Tooltip("Remove placed armor.")]
    public bool RemoveArmor = true;
    
    [MaintainOrder]
    [Tooltip("Remove placed Aid items, such as stimpaks, food, and chems.")]
    public bool RemoveAid = true;
    
    [MaintainOrder]
    [Tooltip("Worldspaces to ignore when removing loot items.")]
    public List<IFormLinkGetter<IWorldspaceGetter>> WorldspacesToIgnore { get; set; } = [];
    
    [MaintainOrder]
    [Tooltip("Cells to ignore when removing loot items.")]
    public List<IFormLinkGetter<ICellGetter>> CellsToIgnore { get; set; } = [];
}