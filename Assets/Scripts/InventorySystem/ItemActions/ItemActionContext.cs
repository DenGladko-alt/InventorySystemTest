namespace InventorySystem
{
    public class ItemActionContext
    {
        public InventoryManager InventoryManager { get; }
        public Player Player { get; }
        public ItemDefinition Item { get; }

        public ItemActionContext(InventoryManager inventoryManager, Player player, ItemDefinition item)
        {
            InventoryManager = inventoryManager;
            Player = player;
            Item = item;
        }
    }
}