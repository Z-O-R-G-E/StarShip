using UnityEngine;


namespace StarShip.Interfaces
{
    internal interface IPlayerModel
    {
        float MaxHP { get; }
        float CurrentHP { get; set; }
    }
}