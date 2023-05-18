using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryCharacter : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _secondaryCharacterSpriteRenderer;
    [SerializeField]private int _removeFromColor = 100;
    private int _greenBlueColor = 255;

    private void Start()
    {
        Vihta.Instance.OnVihtaSucceed += Vihta_OnVihtaSucceed;
    }

    private void Vihta_OnVihtaSucceed(object sender, System.EventArgs e)
    {
        _greenBlueColor -= _removeFromColor;

        if (_greenBlueColor <= 0)
        {
            _greenBlueColor = 0;
        }
        _secondaryCharacterSpriteRenderer.color = new Color(255, _greenBlueColor, _greenBlueColor);
    }
}
