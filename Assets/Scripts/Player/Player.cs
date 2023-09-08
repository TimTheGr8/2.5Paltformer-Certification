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
    [SerializeField]
    private float _rollOffset = 12.56f;

    private CharacterController _controller;
    private Animator _anim;
    private int _score = 0;
    private float _walk = 0.0f;
    private Vector3 _direction;
    private Vector3 _velocity;
    private float _yVelocity = 0.0f;
    private float _yRotation = 0;
    private bool _jumping = true;
    private bool _onLedge = false;
    private bool _rolling = false;
    private float _rollWalk = 0;
    private Ledge _activeLedge;

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
        {
            _yVelocity -= _gravity;
            if (!_jumping)
            {
                _jumping = true;
                _anim.SetBool("Jumping", _jumping);
            }
        }

        if (_controller.isGrounded)
        {
            _direction = new Vector3(0, 0, _walk);
            _velocity = _direction * _speed;
            if (_jumping)
            {
                _jumping = false;
                _anim.SetBool("Jumping", _jumping);
            }
        }
        transform.eulerAngles = new Vector3(0, _yRotation, 0);
        _velocity.y = _yVelocity;
        _controller.Move(_velocity * Time.deltaTime);
    }

    public void Jump()
    {
        if (_controller.isGrounded && !_rolling)
        {
            _yVelocity = _jumpHeight;
        }
    }

    public void SetWalk(float walk)
    {
        _rollWalk = walk;

        if (!_rolling)
        {
            _walk = walk;
            if (walk == 1)
            {
                _yRotation = 0;
            }
            if (walk == -1)
            {
                _yRotation = 180;
            }
            _anim.SetFloat("Speed", Mathf.Abs(_walk));
        }
    }

    public void GrabLedge(Vector3 handPosition, Ledge currentLedge)
    {
        _anim.SetBool("LedgeGrab", true);
        _onLedge = true;
        _controller.enabled = false;
        transform.position = handPosition;
        _anim.SetBool("Jumping", false);
        _activeLedge = currentLedge;
    }

    public void ClimbLedge()
    {
        if(_onLedge)
            _anim.SetTrigger("ClimbLedge");
    }

    public void ClimbComplete()
    {
        transform.position = _activeLedge.GetStandPos();
        _anim.SetBool("LedgeGrab", false);
        _onLedge = false;
        _controller.enabled = true;
    }

    public void Roll()
    {
        if(_controller.isGrounded && !_jumping && Mathf.Abs(_walk) > 0f)
        {
            _rolling = true;
            _anim.SetTrigger("Roll");
        }
    }

    public void RollComplete()
    {
        _rolling = false;
        SetWalk(_rollWalk);
    }

    public void AdjustScore(int score)
    {
        _score += score;
        UIManager.Instance.UpdateScoreText(_score);
    }
}
