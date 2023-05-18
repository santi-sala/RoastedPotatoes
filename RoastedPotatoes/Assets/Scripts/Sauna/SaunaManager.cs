using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SaunaManager : MonoBehaviour
{
    public static SaunaManager Instance { get; private set; }

    public event EventHandler OnStateChange;
    private enum State
    {
        Water,
        Vihta
    }
    
    [SerializeField] private float _maxTimer;
    private float _currentTime = 0.0f;
    private float _changeState = 5f;
    private State _currentState = State.Water;
    private bool _isPlaying;

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    private void Start()
    {       
        _currentTime = _maxTimer;
    }

    // Update is called once per frame
    void Update()
    {
        _currentTime -= Time.deltaTime;
        if (_currentTime < 0f)
        {            
            //Debug.Log("Finished!!");
            //_changeState = 0;
        }
        _changeState -= Time.deltaTime;
        if (_changeState <= 0)
        {
            if (_isPlaying)
            {
                _currentState = State.Water;
                _isPlaying = !_isPlaying;
                OnStateChange?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                _currentState = State.Vihta;
                _isPlaying = !_isPlaying;
                OnStateChange?.Invoke(this, EventArgs.Empty);
            }     
            
            _changeState = 5f;
        }
        Debug.Log(_currentState.ToString());        
    }

    public float GetCurrentTime()
    {        
        return 1 - (_currentTime / _maxTimer);
    }

    public string GetCurrentState()
    {
        return _currentState.ToString();
    }
}
