using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Skiing_Movement : MonoBehaviour
{
    [SerializeField] float _degTurnRate = 1f;
    [SerializeField] float _speed = 10f;

    [SerializeField] float _turn;
    float rotation = 0;

    DefaultInput _playerActions;
    Rigidbody2D _rb;
    SpriteRenderer _sR;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _playerActions = new DefaultInput();
        _playerActions.Enable();
        _sR = transform.Find("Sprite").GetComponent<SpriteRenderer>();

        turnLeft();
    }

    void FixedUpdate()
    {
        CheckRotation();
        rotation += _turn * Time.fixedDeltaTime;
        rotation = Mathf.Clamp(rotation, -50, 50);
        _rb.velocity = -transform.up * _speed;
        transform.rotation = Quaternion.Euler(0,0,rotation);

        if (transform.rotation == Quaternion.Euler(0, 0, 50))
        {
            turnLeft();
        }
        else if (transform.rotation == Quaternion.Euler(0, 0, -50))
        {
            turnRight();
        }
    }

    void CheckRotation()
    {
        if (_playerActions.ControlScheme.Movement_Left.IsPressed())
        {
            turnLeft();
        }
        else if (_playerActions.ControlScheme.Movement_Right.IsPressed())
        {
            turnRight();
        }
    }

    void turnRight()
    {
        _turn = _degTurnRate;
        _sR.flipX = true;
        _sR.gameObject.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 25f));
    }

    void turnLeft()
    {
        _turn = -_degTurnRate;
        _sR.flipX = false;
        _sR.gameObject.transform.localRotation = Quaternion.Euler(new Vector3(0,0,-25f));
    }
}
