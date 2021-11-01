using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _cooldownBetweenSpawn;
    [SerializeField] private ItemSpawner[] _itemsSpawner;

    private float _curentTime;

    private void Update()
    {
        _curentTime += Time.deltaTime;
        if(_curentTime >= _cooldownBetweenSpawn)
        {
            var idOfSpawn = Random.Range(0, _itemsSpawner.Length);
            _itemsSpawner[idOfSpawn].Spawn();
            _curentTime = 0;
        }
    }
}
