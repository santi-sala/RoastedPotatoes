using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beats_Down : MonoBehaviour
{
    private const string TAG_ACTIVATOR = "Arrow";
    private const string TAG_MISSED = "Missed";
    [SerializeField] private bool _canBepressed;

    void Start()
    {
        PlayerInput.Instance.OnDownPressed += Instance_OnDownPressed;
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

    private void Instance_OnDownPressed(object sender, System.EventArgs e)
    {
        if (_canBepressed)
        {
            PlayerInput.Instance.OnDownPressed -= Instance_OnDownPressed;
            _canBepressed = false;
            Debug.Log("It can be pressed");
            DiscoManager.Instance.NoteHit();
            Destroy(gameObject);
        }
    }
}
