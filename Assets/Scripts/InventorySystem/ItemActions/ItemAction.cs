using UnityEngine;

namespace InventorySystem
{
    public abstract class ItemAction : ScriptableObject
    {
        public abstract bool CanActivate(ItemActionContext context);
        public abstract void Activate(ItemActionContext context);
    }
}