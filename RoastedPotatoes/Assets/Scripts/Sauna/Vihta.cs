using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vihta : MonoBehaviour
{
    private const string STATE_IS_VIHTA = "Vihta";

    public static Vihta Instance { get; private set; }

    public event EventHandler OnVihtaSucceed;

    [SerializeField] private Image _vihtaFiller;
    private float _addTofiller = 0.1f;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        SaunaManager.Instance.OnStateChange += SaunaManager_OnStateChange;
        SaunaPlayerInput.Instance.OnAlternatePressed += SaunaPlayerInput_OnAlternatePressed;
        Hide();
    }

    private void SaunaPlayerInput_OnAlternatePressed(object sender, System.EventArgs e)
    {
        _vihtaFiller.fillAmount = _vihtaFiller.fillAmount + _addTofiller;

        if (_vihtaFiller.fillAmount >= 1)
        {
            _addTofiller -= 0.02f;
            OnVihtaSucceed?.Invoke(this, EventArgs.Empty);
        }
    }

    // Update is called once per frame
    private void SaunaManager_OnStateChange(object sender, System.EventArgs e)
    {
        if (SaunaManager.Instance.GetCurrentState() == STATE_IS_VIHTA)
        {
            Show();
        }
        else
        {
            Hide();
            _vihtaFiller.fillAmount = 0;
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
