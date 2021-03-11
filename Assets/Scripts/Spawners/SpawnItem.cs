using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpawnItem : MonoBehaviour
{
    [SerializeField] protected float _minXDistance;
    [SerializeField] protected float _maxXDistance;

    protected Vector3 _lastSpawnPosition;

    private void Start()
    {
        _lastSpawnPosition = new Vector3(0, 0, 0);
    }

    protected void Spawn(GameObject spawnItem, Vector3 spawnPosition)
    {
       var item = Instantiate(spawnItem, spawnPosition, Quaternion.identity);
        _lastSpawnPosition = item.transform.position;
    }

    public abstract void SpawnItems();
}
