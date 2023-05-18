using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Image _timer;
    // Update is called once per frame
    void Update()
    {
        _timer.fillAmount = SaunaManager.Instance.GetCurrentTime();
    }
}
