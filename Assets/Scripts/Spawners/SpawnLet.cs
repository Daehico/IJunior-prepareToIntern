using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLet : SpawnItem
{
    [SerializeField] private Let _let;

    public override void SpawnItems()
    {
        var spawnDistance = Random.Range(_minXDistance, _maxXDistance);
        Spawn(_let.gameObject, new Vector3(_lastSpawnPosition.x + spawnDistance, _lastSpawnPosition.y, _lastSpawnPosition.z));
    }
}
