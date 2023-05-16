using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Skiing_StartStop : MonoBehaviour
{
    DefaultInput _playerActions;

    Skiing_CameraFollow _skiiCamera;
    Skiing_Movement _skiiMovement;
    Skiing_Hits _skiiHits;
    GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        _playerActions = new DefaultInput();
        _playerActions.Enable();

        _playerActions.ControlScheme.Interaction.started += BeginGame;

        _skiiCamera = GameObject.FindObjectOfType<Skiing_CameraFollow>();
        _skiiMovement = GameObject.FindObjectOfType<Skiing_Movement>();
        //_skiiHits = GameObject.FindObjectOfType<Skiing_Hits>();
        _player = GameObject.Find("PlayerRoot");

        DisableAllComponents();
        Invoke("StartBeginningSequence", 3);
    }

    void StartBeginningSequence()
    {
        _playerActions.Enable();
    }

    void BeginGame(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        _skiiCamera.enabled = true;
        _skiiMovement.enabled = true;
        //_skiiHits.enabled = true;
    }

    public void StartEndingSequence()
    {
        _skiiCamera.enabled = false;

        Invoke("EndGame", 5);
    }

    void EndGame()
    {
        _player.GetComponent<World_ActivityInteraction>().WorldLoadPrep();
    }

    void DisableAllComponents()
    {
        _skiiCamera.enabled = false;
        _skiiMovement.enabled = false;
        //_skiiHits.enabled = false;
    }
}
