using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private int _coins;

    public int Coins => _coins;
    public float PlayerXPosition => transform.position.x;

    public event UnityAction<int> CoinsChange;

    public void ApplyCoins(int coin)
    {
        _coins += coin;
        CoinsChange?.Invoke(_coins);
    }
    public void Die()
    {
        SceneManager.LoadScene(1);
    }
}
