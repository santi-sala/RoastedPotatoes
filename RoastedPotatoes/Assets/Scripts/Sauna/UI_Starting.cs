using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Starting : MonoBehaviour
{
    private const string STATE_IS_STARTING = "Starting";

    public static UI_Starting Instance { get; private set; }

    public event EventHandler OnStartGame;

    private void Awake()
    {
        Instance = this;        
    }
    private void Start()
    {
        Show();
        SaunaPlayerInput.Instance.OnInteractionPressed += SaunaPlayerInput_OnInteractionPressed;
    }

    private void SaunaPlayerInput_OnInteractionPressed(object sender, System.EventArgs e)
    {
        if (SaunaManager.Instance.GetCurrentState() == STATE_IS_STARTING)
        {
            OnStartGame?.Invoke(this, EventArgs.Empty);
            SaunaPlayerInput.Instance.OnInteractionPressed -= SaunaPlayerInput_OnInteractionPressed;
            SaunaManager.Instance.ChangeStateToWater();
            Hide();
        }
    }

    private void Show()
    {
        gameObject.SetActive(true);        
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
