using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skiing_Hits : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Invoke("DeleteHitbox", 0.5f);
    }

    void DeleteHitbox()
    {
        gameObject.GetComponent<PolygonCollider2D>().enabled = false;
    }
}
