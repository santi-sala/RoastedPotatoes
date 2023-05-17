using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_Score : MonoBehaviour
{
    public static UI_Score Instance { get; private set; }

    [SerializeField] private TextMeshProUGUI _txtCurrentScore;
    [SerializeField] private TextMeshProUGUI _txtCurrentMultiplier;


    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        _txtCurrentScore.text = "Score: 0";
        _txtCurrentMultiplier.text = "Multiplier: x1";
    }

    public void DisplayCurrentScore(int score)
    {
        _txtCurrentScore.text = "Score: " + score.ToString();
    }
    public void DisplayCurrentMultiplier(int multiplier)
    {
        _txtCurrentMultiplier.text = "Multiplier: x" + multiplier.ToString();
    }

    public string GetFinalScore()
    {
        return _txtCurrentScore.text;
    }
}
