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

        SceneManager.LoadScene(activityScene);
    }

    public void LoadWorld()
    {
        SceneManager.LoadScene(currentDayScene);
    }
}
