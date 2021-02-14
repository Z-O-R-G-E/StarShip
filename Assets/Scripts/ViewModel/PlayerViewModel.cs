using System;
using UnityEngine;
using StarShip.Interfaces;


namespace StarShip.ViewModel 
{
    internal class PlayerViewModel : IPlayerViewModel
    {
        private bool _isDead;
        public event Action<float> OnHPChange;
        public IPlayerModel PlayerModel { get; }
        public bool IsDead => _isDead;

        public PlayerViewModel(IPlayerModel playerModel)
        {
            PlayerModel = playerModel;
        }

        public void ApplyDamage(float damage)
        {
            PlayerModel.CurrentHP -= damage;
            if (PlayerModel.CurrentHP <= 0)
            {
                _isDead = true;
            }
            OnHPChange?.Invoke(PlayerModel.CurrentHP);
        }
    }
}