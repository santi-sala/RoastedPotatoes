using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class World_Player_Movement : MonoBehaviour
{
    DefaultInput _playerActions;
    Rigidbody2D _rb;

    [SerializeField] float _sideWaysMoveSpeed = 10f;
    [SerializeField] float _moveSpeed = 20f;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        _playerActions = new DefaultInput();
        _playerActions.Enable();

        _rb = GetComponent<Rigidbody2D>();
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
            _rb.velocity = new Vector2(_rb.velocity.x, _sideWaysMoveSpeed);
        }
        else if (_playerActions.ControlScheme.Movement_Down.IsPressed())
        {
            _rb.velocity = new Vector2(_rb.velocity.x, -_sideWaysMoveSpeed);
        }
        else
        {
            _rb.velocity = new Vector2(_rb.velocity.x, 0);
        }

        //Move left and right
        if (_playerActions.ControlScheme.Movement_Left.IsPressed())
        {
            _rb.velocity = new Vector2(-_moveSpeed ,_rb.velocity.y);
        }
        else if (_playerActions.ControlScheme.Movement_Right.IsPressed())
        {
            _rb.velocity = new Vector2(_moveSpeed, _rb.velocity.y);
        }
        else
        {
            _rb.velocity = new Vector2(0, _rb.velocity.y);
        }
    }
}
