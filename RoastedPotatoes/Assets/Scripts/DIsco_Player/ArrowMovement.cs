using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    [SerializeField] private float _beatTempo;
    // Start is called before the first frame update
    void Start()
    {
        _beatTempo /= 60f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0f, _beatTempo * Time.deltaTime);
    }
}
