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
        _player.CoinsChange += CoinsChange;
        _text.text = _player.Coins.ToString();
    }

    private void OnDisable()
    {
        _player.CoinsChange -= CoinsChange;
    }

    private void CoinsChange(int coins)
    {
        _text.text = coins.ToString();
    }
}
