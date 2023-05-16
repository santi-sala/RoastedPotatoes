using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class World_ActivityInteraction : World_ActivitySwapper
{
    DefaultInput _playerActions;
    string _activitySceneName;
    bool _inTrigger = false;

    private void Awake()
    {
        _playerActions = new DefaultInput();
        _playerActions.Enable();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Interactable"))
        {
            _activitySceneName = collision.GetComponent<World_ActivityInteractable>().activitySceneName;
            _inTrigger = true;
        }
    }

    private void Update()
    {
        if (_inTrigger && _playerActions.ControlScheme.Interaction.triggered)
        {
            LoadActivity(_activitySceneName);
            _inTrigger = false;
        }
    }
}
