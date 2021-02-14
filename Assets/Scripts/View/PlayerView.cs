using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarShip.Interfaces;
using UnityEngine.UI;

namespace StarShip.View 
{
    internal class PlayerView : MonoBehaviour
    {
        [SerializeField] private Text _text;
        private IPlayerViewModel _playerViewModel;

        public void Initialize(IPlayerViewModel playerViewModel)
        {
            _playerViewModel = playerViewModel;
            _playerViewModel.OnHPChange += OnHPChange;
            OnHPChange(_playerViewModel.PlayerModel.CurrentHP);
        }

        private void OnHPChange(float currentHP)
        {
            _text.text = _playerViewModel.IsDead ? "Вы погибли!" : currentHP.ToString();
        }

        ~PlayerView()
        {
            _playerViewModel.OnHPChange -= OnHPChange;
        }
    }
}