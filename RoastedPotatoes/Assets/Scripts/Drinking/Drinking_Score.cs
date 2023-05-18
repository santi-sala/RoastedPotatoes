using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drinking_Score : MonoBehaviour
{
    int score = -1;

    static public bool startScore = true;

    [SerializeField] float startingTime = 10f;
    [SerializeField] float currentTime = 0f;

    private void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {   
        if (startScore)
        {
            if (currentTime > 0)
            {
                currentTime -= Time.deltaTime;
            }
            else if (currentTime <= 0)
            {
                currentTime = startingTime;
                UpdateScore();
            }
        }
    }

    void UpdateScore()
    {
        score++;
        if (score <= 15)
        {
            transform.GetChild(score).GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
