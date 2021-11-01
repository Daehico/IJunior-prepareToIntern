﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Let : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent(out Player player))
        {
            player.Die();
        }
    }
}
