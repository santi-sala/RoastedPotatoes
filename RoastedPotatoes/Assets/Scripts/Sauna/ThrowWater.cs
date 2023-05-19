using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowWater : MonoBehaviour
{
    private const string STATE_IS_WATER = "Water";
    private const string TAG_FIXED_TRIGGER = "FixedTrigger";

    public static ThrowWater Instance { get; private set; }

    public event EventHandler OnWaterSucceed;

    [SerializeField] private GameObject _triggerMovement;
    [SerializeField] private GameObject _middleTrigger;
    [SerializeField] private GameObject _backGround;
    private bool _canBePressed = false;
    

    private float _triggerSpeed = 0.04f;
    private bool _isEnd;
    private int _goBack = 1;
    private int _timesItWasPressed = 0;
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        SaunaManager.Instance.OnStateChange += SaunaManager_OnStateChange;
        SaunaPlayerInput.Instance.OnInteractionPressed += SaunaPlayerInput_OnInteractionPressed;        
    }

    private void SaunaPlayerInput_OnInteractionPressed(object sender, EventArgs e)
    {
        if (_timesItWasPressed >= 3)
        {
            _timesItWasPressed = 3;
            return;
        }
        if(SaunaManager.Instance.GetCurrentState() == STATE_IS_WATER)
        {            

            if (_canBePressed)
            {
                _timesItWasPressed++;
            }

            if (_timesItWasPressed >= 3)
            {
                ChangeSpeed();
                OnWaterSucceed?.Invoke(this, EventArgs.Empty);
                Hide();
            }
        }        
    }

    private void SaunaManager_OnStateChange(object sender, System.EventArgs e)
    {
        if (SaunaManager.Instance.GetCurrentState() == STATE_IS_WATER)
        {
            Show();
        }
        else
        {
            _timesItWasPressed = 0;
            Hide();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_triggerMovement.transform.position.x >= 3)
        {
            _isEnd = true;
            _goBack = -1;
        }
        if (_triggerMovement.transform.position.x <= -3)
        {
            _isEnd = false;
            _goBack = 1;
        }
        if (_isEnd) { }
        _triggerMovement.transform.position = new Vector3(_triggerMovement.transform.position.x + _triggerSpeed * _goBack, 0,0);

        //Debug.Log("Can be pressed: " + _canBePressed);
        //Debug.Log("Times pressed: " + _timesItWasPressed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == TAG_FIXED_TRIGGER)
        {
            _canBePressed = true;
        }        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == TAG_FIXED_TRIGGER)
        {
            _canBePressed = false;
        }
    }

    public void ChangeSpeed()
    {
        _triggerSpeed += 0.02f;
    }

    private void Show()
    {
        _triggerMovement.SetActive(true);
        _middleTrigger.SetActive(true);
        _backGround.SetActive(true);
    }
    private void Hide()
    {
        _triggerMovement.SetActive(false);
        _middleTrigger.SetActive(false);
        _backGround.SetActive(false);
    }
}
