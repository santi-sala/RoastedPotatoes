using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition_Behaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("UnloadScene", 3.5f);
    }

    void UnloadScene()
    {
        SceneManager.UnloadSceneAsync("TransitioningScene");
    }
}
