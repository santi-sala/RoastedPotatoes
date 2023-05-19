using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoManager : MonoBehaviour
{
    public static DiscoManager Instance { get; private set; }

    [SerializeField] private AudioSource _mainSong;
    //[SerializeField] private bool _startPlaying = false;

    private int _currentScore;
    private int _scorePerNote = 100;
    private bool _isMusicPlaying;
    private bool _flip;

    private int _currentMultiplier;
    private int _multiplierTracker = 0;
    private int[] _multiplierThresholds;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        _currentMultiplier = 1;
        _multiplierThresholds = new int[] { 4, 6, 8 };
        PlayerInput.Instance.OnInteractionPressed += Instance_OnInteractionPressed;
        
    }

    private void Instance_OnInteractionPressed(object sender, System.EventArgs e)
    {
        //_startPlaying = true;

        _mainSong.Play();

        ArrowMovement.Instance.StartArrowMovements();
        PlayerInput.Instance.OnInteractionPressed -= Instance_OnInteractionPressed;

    }

    // Update is called once per frame
    void Update()
    { 
        /*
        if (!_startPlaying)
        {
            if (Input.anyKeyDown)
            {
                _startPlaying = true;
              //BeatScroller.Instance.StartArrowsScrolling();

                
                //_mainSong.Play();
            }
        }
        */
        
    }

    public void NoteHit()
    {
        //Debug.Log("Success!!");

        _multiplierTracker++;
        CheckMultiplierStatus();
        //Debug.Log("Current multiplier is: " + _currentMultiplier);

        _currentScore += _scorePerNote * _currentMultiplier;
        UI_Score.Instance.DisplayCurrentScore(_currentScore);
        UI_Score.Instance.DisplayCurrentMultiplier(_currentMultiplier);
        int poseIndex = RandomNumberGenerator(4);
        int flip = RandomNumberGenerator(2);
        CharacterPoses.Instance.CahangeCharacterPose(false, flip, poseIndex);
    }

    private int RandomNumberGenerator(int final ,int initial = 0)
    {
        int randomnumber = UnityEngine.Random.Range(initial, final);

        return randomnumber;
    }

    public void NoteMissed()
    {
        //Debug.Log("missed!!");

        _multiplierTracker = 0;
        _currentMultiplier = 1;
        UI_Score.Instance.DisplayCurrentMultiplier(_currentMultiplier);
        int flip = RandomNumberGenerator(2);
        CharacterPoses.Instance.CahangeCharacterPose(true, flip);
    }
    private void CheckMultiplierStatus()
    {
        if (_multiplierTracker >= _multiplierThresholds[2])
        {
            _currentMultiplier = 4;
        }
        else if (_multiplierTracker >= _multiplierThresholds[1])
        {
            _currentMultiplier = 3;
        }
        else if (_multiplierTracker >= _multiplierThresholds[0])
        {
            _currentMultiplier = 2;
        }
    }
    
}