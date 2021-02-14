using UnityEngine;
using UnityEngine.UI;
using StarShip.Interfaces;


namespace StarShip.View
{
    internal sealed class EnemyView : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private float _damage;

        private IPlayerViewModel _playerViewModel;

        public void Initialize(IPlayerViewModel playerViewModel)
        {
            _playerViewModel = playerViewModel;
            _button.onClick.RemoveAllListeners();
            _button.onClick.AddListener(() => _playerViewModel.ApplyDamage(_damage));
        }
    }
}