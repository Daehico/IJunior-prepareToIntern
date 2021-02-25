using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMover : MonoBehaviour
{
    [SerializeField] private Player _player;

    private void Update()
    {
        transform.position = new Vector3(_player.PlayerXPosition, transform.position.y, transform.position.z);
    }
}
