using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemSpawner : MonoBehaviour
{
    [SerializeField] protected float _minXDistance;
    [SerializeField] protected float _maxXDistance;
    [SerializeField] protected GameObject _item;

    private Vector3 _lastSpawnPosition;
    private Vector3 _spawnPosition;

    private void Start()
    {
        _lastSpawnPosition = new Vector3(0, 0, 0);
    }

    public void Spawn()
    {
        _spawnPosition = NextSpawnPosition();
        InstantiateItem(_item,_spawnPosition);
    }

    public abstract void InstantiateItem(GameObject spawnItem, Vector3 spawnPosition);
  
    public abstract Vector3 NextSpawnPosition();
}
