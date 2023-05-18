using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_Interaction : MonoBehaviour
{
    DefaultInput _playerActions;

    // Start is called before the first frame update
    void Start()
    {
        _playerActions = new DefaultInput();
        _playerActions.Enable();

        _playerActions.ControlScheme.Interaction.started += LoadWorldScene;
    }

    void LoadWorldScene(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        SceneManager.LoadSceneAsync("TransitioningScene", LoadSceneMode.Additive);
        StartCoroutine(DelayLoadScene());
        _playerActions.ControlScheme.Interaction.started -= LoadWorldScene;
    }

    IEnumerator DelayLoadScene()
    {
        yield return new WaitForSeconds(1.5f);

        SceneManager.LoadSceneAsync("World", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("MainMenuScene");
    }
}
