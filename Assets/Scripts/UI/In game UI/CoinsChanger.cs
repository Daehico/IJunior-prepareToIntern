using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinsChanger : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _text;

    private void OnEnable()
    {
        _player.CoinsChanging += OnCoinsChanged;
        OnCoinsChanged(_player.Coins);
    }

    private void OnDisable()
    {
        _player.CoinsChanging -= OnCoinsChanged;
    }

    private void OnCoinsChanged(int coins)
    {
        _text.text = coins.ToString();
    }
}
