using System;
using UnityEngine;

namespace InventorySystem
{
    
    /// <summary>
    ///  Very basic player controller for testing purposes
    /// </summary>
    public class Player : MonoBehaviour
    {
        [SerializeField, Min(1)] private int maxHealth = 100;

        public int MaxHealth => maxHealth;
        public int CurrentHealth { get; private set; }

        private void Awake()
        {
            CurrentHealth = maxHealth;
        }

        public void Heal(int amount)
        {
            CurrentHealth = Math.Clamp(CurrentHealth + amount, 0, maxHealth);
        }
    }
}