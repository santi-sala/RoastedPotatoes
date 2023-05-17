using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Skiing_Rewards : MonoBehaviour
{
    public bool countTime = false;
    bool active = true;

    [SerializeField] GameObject pointsText;
    static public int pointsCount = 0;

    private void Start()
    {
        pointsText = GameObject.Find("Points");
        UpdatePoints();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (active)
        {
            pointsCount += 1000;
            UpdatePoints();
            active = false;
        }
    }

    void UpdatePoints()
    {
        pointsText.GetComponent<TextMeshProUGUI>().text = pointsCount.ToString();
    }

    private void FixedUpdate()
    {
        if (countTime)
        {
            pointsCount += 1;
            UpdatePoints();
        }
    }
}
