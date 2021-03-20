using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsSpawner : ItemSpawner
{
    [SerializeField] private int _minSpawnedCoins;
    [SerializeField] private int _maxSpawnedCoins;
    [SerializeField] private Vector3 _distanceBetweenCoins;

    public override Vector3 ChangeSpawnPosition()
    {
        var _curentSpawnedCoins = Random.Range(_minSpawnedCoins, _maxSpawnedCoins);    
        return new Vector3(_lastSpawnPosition.x + Random.Range(_minXDistance, _maxXDistance), _lastSpawnPosition.y, _lastSpawnPosition.z);      
    }

    public override void InstantiateItem(GameObject spawnItem, Vector3 spawnPosition)
    {
        var curentSpawnedCoins = Random.Range(_minSpawnedCoins, _maxSpawnedCoins);
        for(int i = 0; i< curentSpawnedCoins; i++)
        {
            var item = Instantiate(spawnItem, spawnPosition, Quaternion.identity);
            _lastSpawnPosition = item.transform.position;
            spawnPosition = _lastSpawnPosition + _distanceBetweenCoins;
        }
    }
}
