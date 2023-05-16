using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class World_ActivityInteraction : World_ActivitySwapper
{
    DefaultInput _playerActions;
    string _activitySceneName;
    bool _inTrigger = false;
    World_Player_Movement _playerMovement;
    GameObject _playerCamera;
    SpriteRenderer _playerSpriteRenderer;

    private void Awake()
    {
        _playerActions = new DefaultInput();
        _playerActions.Enable();
        _playerMovement = GetComponent<World_Player_Movement>();
        _playerCamera = transform.Find("Main Camera").gameObject;
        _playerSpriteRenderer = transform.Find("PlayerSprite").GetComponent<SpriteRenderer>();
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
            ActivityLoadPrep();
        }
    }

    void ActivityLoadPrep()
    {
        _inTrigger = false;
        _playerMovement.DisableMovement();
        
        LoadActivity(_activitySceneName);

        _playerSpriteRenderer.enabled = false;
        _playerCamera.GetComponent<Camera>().enabled = false;
        _playerCamera.GetComponent<AudioListener>().enabled = false;
    }

    public void WorldLoadPrep()
    {
        _playerMovement.EnableMovement();

        LoadWorld();

        _playerSpriteRenderer.enabled = true;
        _playerCamera.GetComponent<Camera>().enabled = true;
        _playerCamera.GetComponent<AudioListener>().enabled = true;
    }
}
