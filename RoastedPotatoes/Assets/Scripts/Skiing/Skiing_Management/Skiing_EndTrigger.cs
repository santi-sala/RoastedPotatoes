using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skiing_EndTrigger : MonoBehaviour
{
    Skiing_StartStop skiiStartStop;

    private void Start()
    {
        skiiStartStop = GameObject.FindObjectOfType<Skiing_StartStop>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("EndTrigger");

        if (collision.CompareTag("Player"))
        {
            Debug.Log("EndTrigger");
            skiiStartStop.StartEndingSequence();
        }
    }
}
