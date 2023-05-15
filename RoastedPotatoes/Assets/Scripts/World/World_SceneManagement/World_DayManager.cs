using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class World_DayManager : MonoBehaviour
{
    string[] daySceneNames = new string[] { "World_Mo", "World_Tu" };

    public int currentDayCount = 0;
    public string currentDayScene;

    private void Start()
    {
        currentDayScene = SceneManager.GetActiveScene().name;
    }

    public void ChangeDay()
    {
        currentDayCount++;

        currentDayScene = daySceneNames[currentDayCount];

        SceneManager.LoadScene(currentDayScene);
    }
}
