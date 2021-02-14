using StarShip.Models;
using StarShip.View;
using StarShip.ViewModel;
using UnityEngine;


namespace StarShip
{
    internal sealed class Starter : MonoBehaviour
    {
        [SerializeField] private PlayerView _playerView;
        [SerializeField] private EnemyView _enemyView;

        public Starter()
        {
            var playerModel = new PlayerModel(100);
            var playerViewModel = new PlayerViewModel(playerModel);
            _playerView.Initialize(playerViewModel);
            _enemyView.Initialize(playerViewModel);
        }
    }
}