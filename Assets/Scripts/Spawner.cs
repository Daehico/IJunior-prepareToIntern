using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _minXDistance;
    [SerializeField] private float _maxXDistance;
    [SerializeField] private Let _let;
    [SerializeField] private Coin _coin;
    [SerializeField] private int _minSpawnedCoins;
    [SerializeField] private int _maxSpawnedCoins;
    [SerializeField] private float _cooldownBetweenSpawn;

    private Vector3 _lastSpawnPosition;
    private float _curentTime;

    private void Start()
    {
        _lastSpawnPosition = new Vector3(0, 0, 0);
    }

    private void Update()
    {
        _curentTime += Time.deltaTime;
        if(_curentTime >= _cooldownBetweenSpawn)
        {
            var idOfSpawn = Random.Range(0, 2);
            if (idOfSpawn == 1)
                SpawnCoin();
            else
                SpawnLet();
        }
    }

    private void SpawnCoin()
    {
        var _curentSpawnedCoins = Random.Range(_minSpawnedCoins, _maxSpawnedCoins);
        for(int i = 0; i < _curentSpawnedCoins; i++)
        {
            if(i == 0)
            {
                var coin = Instantiate(_coin, new Vector3(Random.Range(_lastSpawnPosition.x + _minSpawnedCoins, _lastSpawnPosition.x + _maxXDistance), 1f, 0), Quaternion.identity);
                _lastSpawnPosition = coin.transform.position;
            }
            else
            {
                var coin = Instantiate(_coin, new Vector3(_lastSpawnPosition.x + 1f, 1f, 0), Quaternion.identity);
                _lastSpawnPosition = coin.transform.position;
            }
        }
    }

    private void SpawnLet()
    {
        var let = Instantiate(_let, new Vector3(Random.Range(_lastSpawnPosition.x+_minSpawnedCoins, _lastSpawnPosition.x + _maxXDistance),0,0),Quaternion.identity);
        _lastSpawnPosition = let.transform.position;
    }
}
