using UnityEngine;

namespace InventorySystem
{
    [CreateAssetMenu(fileName = "Heal Item Action", menuName = "GameData /Item Actions/ Heal Item Action")]
    public class HealItemAction : ItemAction
    {
        [SerializeField] private int healAmount = 25;

        public override bool CanActivate(ItemActionContext context)
        {
            return context.Player.CurrentHealth > 0;
        }

        public override void Activate(ItemActionContext context)
        {
            context.Player.Heal(healAmount);
        }
    }
}