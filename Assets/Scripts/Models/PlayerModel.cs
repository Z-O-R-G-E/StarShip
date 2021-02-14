using UnityEngine;
using StarShip.Interfaces;


namespace StarShip.Models
{
    internal sealed class PlayerModel : IPlayerModel
    {
        public float MaxHP { get; }
        public float CurrentHP { get; set; }

        public PlayerModel(float maxHP)
        {
            MaxHP = maxHP;
            CurrentHP = MaxHP;
        }
    }
}