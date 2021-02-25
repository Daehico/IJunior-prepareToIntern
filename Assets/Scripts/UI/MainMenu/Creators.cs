using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Creators : MonoBehaviour
{
    [SerializeField] private Animator _animation;

    public void ShowCreators()
    {
        _animation.Play("TextMove");    
    }
}
