using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletedUI : MonoBehaviour
{
    private const string STATES_IS_FINISHED = "Finished";
    public static CompletedUI Instance { get; private set; }

    private void Awake()
    {
        Instance = this;        
    }

    private void Start()
    {
        SaunaManager.Instance.OnStateChange += SaunaManager_OnStateChange;
        Hide();
    }

    private void SaunaManager_OnStateChange(object sender, EventArgs e)
    {
        if (SaunaManager.Instance.GetCurrentState() == STATES_IS_FINISHED )
        {
            Show();
        }
    }

    public void Show()
    {
        gameObject.SetActive(true);
        Invoke("LoadWorld", 5);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }

    private void LoadWorld()
    {
        GameObject.Find("PlayerRoot").GetComponent<World_ActivityInteraction>().WorldLoadPrep();
    }
}
