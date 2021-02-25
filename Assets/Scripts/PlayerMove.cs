using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector2 _forceJump;

    private Rigidbody2D _rb2D;

    private void Start()
    {
        _rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        transform.Translate(Vector3.right * _speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
            Jump();
    }
    private void Jump()
    {
        _rb2D.velocity = new Vector2(_speed, 0);
        _rb2D.AddForce(_forceJump * Time.deltaTime);
    }
}
