using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : SpawnItem
{
    [SerializeField] private Coin _coin;
    [SerializeField] private int _minSpawnedCoins;
    [SerializeField] private int _maxSpawnedCoins;
    [SerializeField] private int _distanceBetweenCoins;

    public override void SpawnItems()
    {
        var _curentSpawnedCoins = Random.Range(_minSpawnedCoins, _maxSpawnedCoins);
        for (int i = 0; i < _curentSpawnedCoins; i++)
        {
            if (i == 0)
                Spawn(_coin.gameObject, new Vector3(_lastSpawnPosition.x + Random.Range(_minXDistance, _maxXDistance), _lastSpawnPosition.y, _lastSpawnPosition.z));
            else
                Spawn(_coin.gameObject, new Vector3(_lastSpawnPosition.x + _distanceBetweenCoins, _lastSpawnPosition.y, _lastSpawnPosition.z));
        }
    }
}
