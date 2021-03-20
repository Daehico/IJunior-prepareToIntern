using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetSpawner : ItemSpawner
{
    public override Vector3 ChangeSpawnPosition()
    {
        var spawnDistance = Random.Range(_minXDistance, _maxXDistance);
        return new Vector3(_lastSpawnPosition.x + spawnDistance, _lastSpawnPosition.y, _lastSpawnPosition.z);
    }

    public override void InstantiateItem(GameObject spawnItem, Vector3 spawnPosition)
    {
        var item = Instantiate(spawnItem, spawnPosition, Quaternion.identity);
        _lastSpawnPosition = item.transform.position;
    }
}
