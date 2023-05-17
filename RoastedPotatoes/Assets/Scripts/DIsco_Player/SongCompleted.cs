using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SongCompleted : MonoBehaviour
{
    [SerializeField] private GameObject _completedUI;
    [SerializeField] private TextMeshProUGUI _txtScore;
    

    private void Start()
    {
        Hide();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Arrow")
        {
            _txtScore.text = UI_Score.Instance.GetFinalScore();
            Show();

            Invoke("LoadWorld", 5);
        }
        
    }

    private void Show()
    {
        _completedUI.SetActive(true);
    }

    private void LoadWorld()
    {
        GameObject.Find("PlayerRoot").GetComponent<World_ActivityInteraction>().WorldLoadPrep();
    }

    private void Hide()
    {
        _completedUI.SetActive(false);
    }

}
