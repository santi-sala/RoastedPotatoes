using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class World_ActivitySwapper : MonoBehaviour
{
    string currentDayScene;

    public void LoadActivity(string activityScene)
    {
        string loadedScene = SceneManager.GetActiveScene().name;

        currentDayScene = "World_NoPlayer";

        SceneManager.LoadSceneAsync("TransitioningScene", LoadSceneMode.Additive);

        GameObject.FindObjectOfType<MusicFade>().FadeMusic();

        StartCoroutine(DelayActivityLoad(loadedScene, activityScene));
    }

    IEnumerator DelayActivityLoad(string currentScene, string activityScene)
    {
        yield return new WaitForSeconds(1.5f);

        LoadActivityDelayed(currentScene, activityScene);
    }

    void LoadActivityDelayed(string currentScene, string activityScene)
    {
        SceneManager.UnloadSceneAsync(currentScene);
        SceneManager.LoadSceneAsync(activityScene, LoadSceneMode.Additive);
    }

    public void LoadWorld()
    {
        string fromScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadSceneAsync("TransitioningScene", LoadSceneMode.Additive);

        StartCoroutine(DelayWorldLoad(fromScene));
    }

    IEnumerator DelayWorldLoad(string fromScene)
    {
        yield return new WaitForSeconds(1.5f);

        LoadWorldDelayed(fromScene);
    }

    void LoadWorldDelayed(string fromScene)
    {
        SceneManager.UnloadSceneAsync(fromScene);
        SceneManager.LoadSceneAsync(currentDayScene, LoadSceneMode.Additive);
    }
}
