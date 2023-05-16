using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    public static ArrowMovement Instance { get; private set; }
    [SerializeField] private float _beatTempo;
    private bool _isPlaying = false;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        _beatTempo /= 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if(_isPlaying)
        {
            transform.position -= new Vector3(0f, _beatTempo * Time.deltaTime);
        }
    }

    public void StartArrowMovements()
    {
        _isPlaying = true;
    }
}
