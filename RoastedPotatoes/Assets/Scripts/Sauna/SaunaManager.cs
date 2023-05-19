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
        Starting,
        Water,
        Vihta,
        Finished
    }
    
    [SerializeField] private float _maxTimer;
    private float _currentTime = 0.0f;
    private State _currentState = State.Starting;
    //private float _changeState = 5f;
    private bool _startTimer = false;

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    private void Start()
    {       
        _currentTime = _maxTimer;
        Vihta.Instance.OnVihtaSucceed += Vihta_OnVihtaSucceed;
        ThrowWater.Instance.OnWaterSucceed += ThrowWater_OnWaterSucceed;
        UI_Starting.Instance.OnStartGame += UI_starting_OnStartGame;
        
        // Testing
        _currentState = State.Starting;
    }

    private void UI_starting_OnStartGame(object sender, EventArgs e)
    {
        _currentState = State.Water;
        _startTimer = true;
    }

    private void ThrowWater_OnWaterSucceed(object sender, EventArgs e)
    {
        _currentState = State.Vihta;
        OnStateChange?.Invoke(this, EventArgs.Empty);
    }

    private void Vihta_OnVihtaSucceed(object sender, EventArgs e)
    {
        _currentState = State.Water;
        OnStateChange?.Invoke(this, EventArgs.Empty);
    }

    

    // Update is called once per frame
    void Update()
    {
        if (_currentState == State.Starting)
        {
            return;
        }

        if (_startTimer)
        {
            _currentTime -= Time.deltaTime;
            if (_currentTime < 0f)
            {            
                Debug.Log("Finished!!");
                _startTimer = false;
                _currentState= State.Finished;
                OnStateChange?.Invoke(this, EventArgs.Empty);
                //_changeState = 0;
            }

        }
        /*
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
        */
        Debug.Log(_currentState.ToString());        
    }

    public float GetCurrentTime()
    {        
        return 1 - (_currentTime / _maxTimer);
    }

    public string GetCurrentState()
    {
        //Debug.Log("State is: " + _currentState.ToString());
        return _currentState.ToString();
    }

    public void ChangeStateToWater()
    {
        _currentState= State.Water;
        OnStateChange?.Invoke(this, EventArgs.Empty);
    }

    public void ChangeStateToFinished()
    {
        _currentState = State.Finished;
        OnStateChange?.Invoke(this, EventArgs.Empty);
    }
}
