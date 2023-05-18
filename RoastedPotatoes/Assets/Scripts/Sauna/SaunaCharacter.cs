using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaunaCharacter : MonoBehaviour
{
    [SerializeField] private GameObject _mainCharacter;
    [SerializeField] private SpriteRenderer _saunaCharacterSpriteRender;
    [SerializeField] private Sprite[] _saunaCharacterSpritesList;

    private int _indexSpritesList = 0;
    private bool _isVihtaUp = true;
    private bool _isWater = true;

    // Start is called before the first frame update
    void Start()
    {
        SaunaPlayerInput.Instance.OnInteractionPressed += SaunaPlayerInput_OnInteractionPressed;
        SaunaPlayerInput.Instance.OnAlternatePressed += SaunaPlayerPressed;

        _saunaCharacterSpriteRender = _mainCharacter.GetComponent<SpriteRenderer>();
        _saunaCharacterSpriteRender.sprite = _saunaCharacterSpritesList[_indexSpritesList];
    }

    private void SaunaPlayerPressed(object sender, System.EventArgs e)
    {
        if (_isVihtaUp)
        {
            _saunaCharacterSpriteRender.sprite = _saunaCharacterSpritesList[2];
            _isVihtaUp = false;
        }
        else
        {
            _saunaCharacterSpriteRender.sprite = _saunaCharacterSpritesList[3];
            _isVihtaUp = true;
        }
    }

    private void SaunaPlayerInput_OnInteractionPressed(object sender, System.EventArgs e)
    {

        if (_isWater)
        {
            _saunaCharacterSpriteRender.sprite = _saunaCharacterSpritesList[1];
            _isWater = false;
        }
        else
        {
            _saunaCharacterSpriteRender.sprite = _saunaCharacterSpritesList[0];
            _isWater = true;
        }
      //CheckCurrentIndex();
    }

    private void CheckCurrentIndex()
    {
        if (_indexSpritesList > _saunaCharacterSpritesList.Length - 1)
        {
            _indexSpritesList = 0;
        }
    }
    
}
