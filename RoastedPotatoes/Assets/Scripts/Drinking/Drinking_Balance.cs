using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Drinking_Balance : MonoBehaviour
{
    public bool gameOn = true;
    
    DefaultInput _playerActions;

    float bodyAngle;
    float jeansAngle;

    [SerializeField] float difficultyMultiplier = 1;
    [SerializeField] float difficultyClimbSpeed = 0.01f;

    GameObject body;
    GameObject jeans;

    [SerializeField] float startingTime = 1f;
    [SerializeField] float currentTime = 0f;

    Drinking_StartStop _startStop;

    // Start is called before the first frame update
    void Start()
    {
        _playerActions = new DefaultInput();
        _playerActions.Enable();

        _startStop = FindObjectOfType<Drinking_StartStop>();

        currentTime = startingTime;
        jeans = transform.Find("Jeans").gameObject;
        body = jeans.transform.Find("Body").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOn)
        {
            DelayClock();

            CheckForEnd();
        }
    }

    void DelayClock()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
        }
        else if (currentTime <= 0)
        {
            currentTime = startingTime;

            AddDifficulty();

            ConstantUpdateAngles();

            UpdateRotations();
        }
    }

    void AddDifficulty()
    {
        difficultyMultiplier += difficultyClimbSpeed;
    }

    void ConstantUpdateAngles()
    {
        if (bodyAngle >= 0)
        {
            bodyAngle += 1 * difficultyMultiplier;
        }
        if (bodyAngle < 0)
        {
            bodyAngle -= 1 * difficultyMultiplier;
        }

        if (_playerActions.ControlScheme.Movement_Left.IsPressed())
        {
            bodyAngle += 2 * difficultyMultiplier;
        }

        if (_playerActions.ControlScheme.Movement_Right.IsPressed())
        {
            bodyAngle -= 2 * difficultyMultiplier;
        }

        if (jeansAngle >= 0)
        {
            jeansAngle += 1 * difficultyMultiplier / 2;
        }
        if (jeansAngle < 0)
        {
            jeansAngle -= 1 * difficultyMultiplier / 2;
        }

        if (_playerActions.ControlScheme.Movement_Left.IsPressed())
        {
            jeansAngle += 2 * difficultyMultiplier / 2;
        }

        if (_playerActions.ControlScheme.Movement_Right.IsPressed())
        {
            jeansAngle -= 2 * difficultyMultiplier / 2;
        }
    }

    void UpdateRotations()
    {
        jeans.transform.rotation = Quaternion.Euler(0, 0, jeansAngle);
        body.transform.rotation = Quaternion.Euler(0, 0, bodyAngle);
    }

    void CheckForEnd()
    {
        if (jeansAngle > 40 || jeansAngle < -40)
        {
            Invoke("StartEndingSequence", 0.5f);
        }

        if (jeansAngle > 80 || jeansAngle < -80)
        {
            End();
        }
    }

    void StartEndingSequence()
    {
        difficultyMultiplier = 20;
    }

    void End()
    {
        gameOn = false;
        _playerActions.Disable();

        _startStop.BeginEndGame();
    }
}
