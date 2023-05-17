using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beats_Up : MonoBehaviour
{
    private const string TAG_ACTIVATOR = "Arrow";
    private const string TAG_MISSED = "Missed";
    [SerializeField] private bool _canBepressed;
    
    void Start()
    {
        PlayerInput.Instance.OnUpPressed += Instance_OnUpPressed;
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
        }
    }

    private void Instance_OnUpPressed(object sender, System.EventArgs e)
    {
        if (_canBepressed)
        {
            PlayerInput.Instance.OnUpPressed -= Instance_OnUpPressed;
            _canBepressed = false;
            //Debug.Log("It can be pressed");
            DiscoManager.Instance.NoteHit();
            Destroy(gameObject);
        }
    }
}
