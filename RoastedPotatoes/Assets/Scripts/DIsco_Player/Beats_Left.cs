using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beats_Left : MonoBehaviour
{
    //public  Beats Instance { get; private set; }

    private const string TAG_ACTIVATOR = "Arrow";
    private const string TAG_MISSED = "Missed";
    //private const string TAG_STARTLISTENING = "StartListening";

    [SerializeField] private bool _canBepressed;
    //[SerializeField] private bool _wasALreadyPressed;
    //[SerializeField] private DefaultInput _playerInput;

    private void Awake()
    {
        //Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        PlayerInput.Instance.OnLeftPressed += Instance_OnLeftPressed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == TAG_ACTIVATOR)
        {
            _canBepressed = true;
        }
        if (other.tag == TAG_MISSED)
        {
            _canBepressed = false;
            DiscoManager.Instance.NoteMissed();
            //Debug.Log("Multiplier lost");
        }       
    }

    private void Instance_OnLeftPressed(object sender, System.EventArgs e)
    {
        //Debug.Log("Left is prressed");

        if (_canBepressed)
        {
            PlayerInput.Instance.OnLeftPressed -= Instance_OnLeftPressed;
            _canBepressed = false;
            //Debug.Log("It can be pressed");
            DiscoManager.Instance.NoteHit();
            //gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }


    
    
}
