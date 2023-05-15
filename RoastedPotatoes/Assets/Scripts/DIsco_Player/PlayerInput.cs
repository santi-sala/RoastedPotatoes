using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    private DefaultInput _playerActions;
   

    // Start is called before the first frame update
    void Awake()
    {
        _playerActions = new DefaultInput();
        _playerActions.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerActions.ControlScheme.Movement_Up.triggered)
        {
            Debug.Log("sup!!");
        }

        if( _playerActions.ControlScheme.Movement_Down.triggered)
        {
            Debug.Log("yup");
        };
    }
}
