using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int _lives = 3;
    [SerializeField]
    private float _speed = 5.0f;
    [SerializeField]
    private float _gravity = 1.3f;
    [SerializeField]
    private float _jumpHeight = 20.0f;

    private CharacterController _controller;
    private Animator _anim;
    private float _walk = 0.0f;
    private Vector3 _direction;
    private Vector3 _velocity;
    private float _yVelocity = 0.0f;
    private int _jumpCount = 0;

    void Start()
    {
        _controller = GetComponent<CharacterController>();
        if (_controller == null)
            Debug.LogError("There is no Character Controller on the Player.");
        _anim = GetComponentInChildren<Animator>();
        if (_anim == null)
            Debug.LogError("There is no Animator on the Player.");
    }

    void FixedUpdate()
    {
        CalculateMovement();
    }

    private void CalculateMovement()
    {
        if (!_controller.isGrounded)
            _yVelocity -= _gravity;

        if(_controller.isGrounded)
        {
            _direction = new Vector3(0, 0, _walk);
            _jumpCount = 0;
            _velocity = _direction * _speed;
        }
        _velocity.y = _yVelocity;
        _controller.Move(_velocity * Time.deltaTime);
    }

    public void Jump()
    {
        if (_jumpCount < 1)
        {
            _jumpCount++;
            if (_jumpCount == 1)
                _yVelocity = _jumpHeight;
            if (_jumpCount == 2)
                _yVelocity += _jumpHeight;
        }
    }

    public void SetWalk(float walk)
    {
        _walk = walk;
        if (walk == 0)
            _anim.SetBool("IsWalking", false);
        else
            _anim.SetBool("IsWalking", true);
    }
}