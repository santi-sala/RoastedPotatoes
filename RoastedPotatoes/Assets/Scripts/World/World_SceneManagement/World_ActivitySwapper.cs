using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class World_ActivitySwapper : MonoBehaviour
{
    string currentDayScene;

    public void LoadActivity(string activityScene)
    {
        currentDayScene = "World_NoPlayer";

        SceneManager.LoadSceneAsync(activityScene);
        SceneManager.LoadSceneAsync("TransitioningScene", LoadSceneMode.Additive);
    }

    public void LoadWorld()
    {
        SceneManager.LoadSceneAsync(currentDayScene);
        SceneManager.LoadSceneAsync("TransitioningScene", LoadSceneMode.Additive);
    }
}
