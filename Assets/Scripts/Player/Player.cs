﻿using IJunior.TypedScenes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int Coins { get; private set; }

    public event UnityAction<int> CoinsChanged;

    public void AddCoins(int coins)
    {
        Coins += coins;
        CoinsChanged?.Invoke(Coins);
    }

    public void Die()
    {
        Game.Load();
    }
}
