using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryCharacter : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _secondaryCharacterSpriteRenderer;
    [SerializeField]private int _removeFromColor = 255;
    private int _removeColorGreen = 255;
    private int _removeColorBlue = 255;

    [SerializeField] private GameObject _swearingBubble;        
    private float _hideSwearingBubbleMax = 2f;
    private float _hideSwearingBubble;
    private bool _isSwearingBubbleVisible = false;

    private int _finishGame = 0;

    private void Start()
    {
        Vihta.Instance.OnVihtaSucceed += Vihta_OnVihtaSucceed;
        ThrowWater.Instance.OnWaterSucceed += ThrowWater_OnWaterSucceed;
        _hideSwearingBubble = _hideSwearingBubbleMax;
        _swearingBubble.SetActive(false);
    }

    private void ThrowWater_OnWaterSucceed(object sender, System.EventArgs e)
    {
        MakeCharactersMoreRed();
    }

    private void Vihta_OnVihtaSucceed(object sender, System.EventArgs e)
    {
        MakeCharactersMoreRed();
    }

    private void Update()
    {
        if (_isSwearingBubbleVisible)
        {
            _hideSwearingBubble = _hideSwearingBubble - Time.deltaTime;

            if (_hideSwearingBubble <= 0)
            {
                _isSwearingBubbleVisible = false;
                _hideSwearingBubble = _hideSwearingBubbleMax;
                _swearingBubble.SetActive(false);
            }
        }
    }

    private void MakeCharactersMoreRed()
    {
        _removeColorGreen -= _removeFromColor;

        if (_removeColorGreen <= 0)
        {
            _removeColorGreen = 0;
            _removeColorBlue -= _removeFromColor;

            if (_removeColorBlue <= 0)
            {
                _removeColorBlue = 0;
            }

        }
        _secondaryCharacterSpriteRenderer.color = new Color(255, _removeColorGreen, _removeColorBlue);
        //Debug.Log(_secondaryCharacterSpriteRenderer.color);
        _swearingBubble.SetActive(true);
        _isSwearingBubbleVisible = true;

        _finishGame++;

        Debug.Log("Finish game is:" + _finishGame);
        if (_removeColorBlue <= 0 && _removeColorGreen <= 0)
        {
            if (_finishGame >= 5)
            {
                Debug.Log("Game is completed");
            }
            Vihta.Instance.OnVihtaSucceed -= Vihta_OnVihtaSucceed;
            ThrowWater.Instance.OnWaterSucceed -= ThrowWater_OnWaterSucceed;


            Invoke("DestroyCharacter", 3);
        }


    }

    private void DestroyCharacter()
    {
        Destroy(gameObject);
    }
}
