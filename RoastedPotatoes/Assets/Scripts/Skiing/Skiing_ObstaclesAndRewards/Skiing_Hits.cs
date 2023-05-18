using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skiing_Hits : MonoBehaviour
{
    bool active = true;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (active)
        {
            Skiing_Rewards.pointsCount -= 1000;
            Invoke("DeleteHitbox", 0.5f);
        }
    }

    void DeleteHitbox()
    {
        gameObject.GetComponent<PolygonCollider2D>().enabled = false;
    }
}
