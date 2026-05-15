using UnityEngine;

namespace InventorySystem
{
    [CreateAssetMenu(fileName = "New Item Definition", menuName = "GameData /Item Definition", order = 0)]
    public class ItemDefinition : ScriptableObject
    {
        [SerializeField] private string id;
        [SerializeField] private string itemName;
        [SerializeField, TextArea] private string description;
        [SerializeField] private Sprite icon;
        [SerializeField] private ItemCategory itemCategory;
        [SerializeField, Min(1)] private int maxStackSize = 1; // Max stack size
        [SerializeField] private ItemRarity itemRarity; // For coloring and sorting
        [SerializeField] private bool isConsumedOnActivation = false;
        [SerializeField] private ItemAction[] itemActions; // What item does on Activation, can be extended to execute multiple actions

        public string Id => id;
        public string ItemName => itemName;
        public string Description => description;
        public Sprite Icon => icon;
        public ItemCategory ItemCategory => itemCategory;
        public int MaxStackSize => maxStackSize;
        public ItemRarity ItemRarity => itemRarity;
        public bool IsConsumedOnActivation => isConsumedOnActivation;
        public ItemAction[] ItemActions => itemActions;
    }

    public enum ItemCategory
    {
        None = 0,
        Weapon = 1,
        Armor = 2,
        Consumable = 3,
        Material = 4,
        Quest = 5
    }
    
    public enum ItemRarity
    {
        Common = 0,      // Gray
        Uncommon = 1,    // Green
        Rare = 2,        // Blue
        Epic = 3,        // Purple
        Legendary = 4    // Gold
    }
}