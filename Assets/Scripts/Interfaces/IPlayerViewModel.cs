using System;
using UnityEngine;

namespace StarShip.Interfaces
{
    internal interface IPlayerViewModel
    {
        IPlayerModel PlayerModel { get; }
        bool IsDead { get; }
        void ApplyDamage(float damage);
        event Action<float> OnHPChange;
    }
}