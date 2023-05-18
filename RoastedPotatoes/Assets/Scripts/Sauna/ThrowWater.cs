using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowWater : MonoBehaviour
{
    private const string STATE_IS_WATER = "Water";
    public static ThrowWater Instance { get; private set; }

    [SerializeField] private GameObject _triggerMovement;

    private float _triggerSpeed = 0.04f;
    private bool _isEnd;
    private int _goBack = 1;
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        SaunaManager.Instance.OnStateChange += SaunaManager_OnStateChange;
    }

    private void SaunaManager_OnStateChange(object sender, System.EventArgs e)
    {
        if (SaunaManager.Instance.GetCurrentState() == STATE_IS_WATER)
        {
            Show();
        }
        else
        {
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
    }

    public void ChangeSpeed()
    {
        _triggerSpeed += 0.02f;
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }
    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
