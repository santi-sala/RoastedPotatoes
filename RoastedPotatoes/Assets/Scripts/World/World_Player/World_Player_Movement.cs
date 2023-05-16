using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class World_Player_Movement : MonoBehaviour
{
    DefaultInput _playerActions;
    Rigidbody2D _rb;
    Animator _animator;
    SpriteRenderer _spriteRenderer;

    [SerializeField] float _sideWaysMoveSpeed = 10f;
    [SerializeField] float _moveSpeed = 20f;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        _playerActions = new DefaultInput();
        EnableMovement();

        _rb = GetComponent<Rigidbody2D>();
        _animator = transform.Find("PlayerSprite").GetComponent<Animator>();
        _spriteRenderer = transform.Find("PlayerSprite").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInputs();
    }

    void CheckInputs()
    {
        //Move up and down
        if (_playerActions.ControlScheme.Movement_Up.IsPressed())
        {
            CallWalkAnim();
            _rb.velocity = new Vector2(_rb.velocity.x, _sideWaysMoveSpeed);
        }
        else if (_playerActions.ControlScheme.Movement_Down.IsPressed())
        {
            CallWalkAnim();
            _rb.velocity = new Vector2(_rb.velocity.x, -_sideWaysMoveSpeed);
        }
        else
        {
            _rb.velocity = new Vector2(_rb.velocity.x, 0);
        }

        //Move left and right
        if (_playerActions.ControlScheme.Movement_Left.IsPressed())
        {
            CallWalkAnim();
            FlipAnimToLeft();
            _rb.velocity = new Vector2(-_moveSpeed ,_rb.velocity.y);
        }
        else if (_playerActions.ControlScheme.Movement_Right.IsPressed())
        {
            CallWalkAnim();
            FlipAnimToRight();
            _rb.velocity = new Vector2(_moveSpeed, _rb.velocity.y);
        }
        else
        {
            _rb.velocity = new Vector2(0, _rb.velocity.y);
        }

        if (_rb.velocity == Vector2.zero)
        {
            CallIdleAnim();
        }
    }

    void CallWalkAnim()
    {
        _animator.SetBool("Walk", true);
    }

    void CallIdleAnim()
    {
        _animator.SetBool("Walk", false);
    }

    void FlipAnimToRight()
    {
        _spriteRenderer.flipX = false;
    }

    void FlipAnimToLeft()
    {
        _spriteRenderer.flipX = true;
    }

    public void DisableMovement()
    {
        _rb.velocity = Vector2.zero;
        _playerActions.Disable();
    }

    public void EnableMovement()
    {
        _playerActions.Enable();
    }
}
