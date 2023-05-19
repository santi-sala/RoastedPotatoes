using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaunaPlayerInput : MonoBehaviour
{
    public static SaunaPlayerInput Instance { get; private set; }

    public event EventHandler OnInteractionPressed;
    public event EventHandler OnAlternatePressed;

    private DefaultInput _playerActions;

    private void Awake()
    {
        Instance = this;
        _playerActions = new DefaultInput();
        _playerActions.Enable();
    }

    private void Start()
    {
        _playerActions.ControlScheme.Interaction.started += Interaction_started;
        _playerActions.ControlScheme.Alternate.started += Alternate_started;
    }

    private void Alternate_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnAlternatePressed?.Invoke(this, EventArgs.Empty);
    }

    private void Interaction_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        //ThrowWater.Instance.ChangeSpeed();
        OnInteractionPressed?.Invoke(this, EventArgs.Empty);
    }
}
