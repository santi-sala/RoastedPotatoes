using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skiing_CameraFollow : MonoBehaviour
{
    Transform _player;
    Vector3 _position = new Vector3(0,0,-10);

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("SkiingPlayer").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, _player.position.y, -10);
    }
}
