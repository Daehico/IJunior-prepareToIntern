using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private const string Game = "Game";

    public int Coins { get; private set; }
    public float PlayerXPosition => transform.position.x;

    public event UnityAction<int> CoinsChanging;

    public void ApplyCoins(int coin)
    {
        Coins += coin;
        CoinsChanging?.Invoke(Coins);
    }

    public void Die()
    {
        SceneManager.LoadScene(Game);
    }
}
