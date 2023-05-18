using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Skiing_StartStop : MonoBehaviour
{
    DefaultInput _playerActions;

    GameObject _backgroundImage;

    [SerializeField] Skiing_Rewards _rewards;

    Skiing_CameraFollow _skiiCamera;
    Skiing_Movement _skiiMovement;
    Skiing_Hits _skiiHits;
    GameObject _player;



    // Start is called before the first frame update
    void Start()
    {
        _playerActions = new DefaultInput();
        _playerActions.Enable();

        _playerActions.ControlScheme.Interaction.started += StartBeginningSequence;


        _skiiCamera = GameObject.FindObjectOfType<Skiing_CameraFollow>();
        _skiiMovement = GameObject.FindObjectOfType<Skiing_Movement>();
        //_skiiHits = GameObject.FindObjectOfType<Skiing_Hits>();
        _player = GameObject.Find("PlayerRoot");
        _backgroundImage = GameObject.Find("BackgroundImage");

        DisableAllComponents();
    }

    void StartBeginningSequence(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {

        _backgroundImage.transform.GetChild(0).gameObject.SetActive(false);
        _backgroundImage.GetComponent<Animator>().SetBool("FadeOut", true);
        Invoke("BeginGame", 3);
    }

    void BeginGame()
    {
        _rewards.countTime = true;
        _skiiCamera.enabled = true;
        _skiiMovement.enabled = true;
        //_skiiHits.enabled = true;
    }

    public void StartEndingSequence()
    {
        _skiiCamera.enabled = false;
        _backgroundImage.GetComponent<Animator>().SetBool("FadeOut", false);
        _rewards.countTime = false;
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
