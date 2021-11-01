using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector2 _forceJump;

    private Rigidbody2D _rigidbody;
    private bool _isGround;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        transform.Translate(Vector3.right * _speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space) && _isGround == true)
            Jump();
    }

    private void Jump()
    {
        _rigidbody.velocity = new Vector2(_speed, 0);
        _rigidbody.AddForce(_forceJump * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponentInParent<GroundMover>())
            _isGround = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponentInParent<GroundMover>())
            _isGround = false;
    }
}
