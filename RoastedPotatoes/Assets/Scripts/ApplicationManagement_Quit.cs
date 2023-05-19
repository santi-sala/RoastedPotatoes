using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ApplicationManagement_Quit : MonoBehaviour
{
    DefaultInput _playerActions;

    // Start is called before the first frame update
    void Start()
    {
        _playerActions = new DefaultInput();
        _playerActions.Enable();

        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        if (_playerActions.ControlScheme.Quit_The_Application.triggered)
        {
            Application.Quit();
        }
    }
}
