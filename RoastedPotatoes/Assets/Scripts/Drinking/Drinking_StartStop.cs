using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drinking_StartStop : MonoBehaviour
{
    DefaultInput _playerActions;

    Drinking_Balance _balance;
    Animator _canvasBackgroundAnimator;

    GameObject _player;

    [SerializeField] GameObject _drinkingText;

    // Start is called before the first frame update
    void Start()
    {
        _playerActions = new DefaultInput();
        _playerActions.Enable();

        _player = GameObject.Find("PlayerRoot");
        _drinkingText = GameObject.Find("DrinkingText");

        _playerActions.ControlScheme.Interaction.started += BeginStartGame;

        _balance = GameObject.FindObjectOfType<Drinking_Balance>();
        _canvasBackgroundAnimator = GameObject.Find("UIBackground").GetComponent<Animator>();
    }

    void BeginStartGame(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        _playerActions.ControlScheme.Interaction.started -= BeginStartGame;
        _drinkingText.SetActive(false);
        _canvasBackgroundAnimator.SetBool("FadeOut", true);
        Invoke("StartGame", 3);
    }

    void StartGame()
    {
        _balance.gameOn = true;
        Drinking_Score.startScore = true;
    }

    public void BeginEndGame()
    {
        _canvasBackgroundAnimator.SetBool("FadeOut", false);
        Drinking_Score.startScore = false;
        Invoke("EndGame", 5);
    }

    void EndGame()
    {
        _player.GetComponent<World_ActivityInteraction>().WorldLoadPrep();
    }
}
