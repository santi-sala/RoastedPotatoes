using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaunaCharacter : MonoBehaviour
{
    private const string STATE_IS_VIHTA = "Vihta";
    private const string STATE_IS_WATER = "Water";

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
        SaunaPlayerInput.Instance.OnAlternatePressed += SaunaPlayerInput_OnAlternatePressed;
        SaunaManager.Instance.OnStateChange += SaunaManager_OnStateChange;

        _saunaCharacterSpriteRender = _mainCharacter.GetComponent<SpriteRenderer>();
        _saunaCharacterSpriteRender.sprite = _saunaCharacterSpritesList[_indexSpritesList];
    }

    private void SaunaManager_OnStateChange(object sender, System.EventArgs e)
    {
        if (SaunaManager.Instance.GetCurrentState() == STATE_IS_WATER)
        {
            _saunaCharacterSpriteRender.sprite = _saunaCharacterSpritesList[0];
        }
        if (SaunaManager.Instance.GetCurrentState() == STATE_IS_VIHTA)
        {
            _saunaCharacterSpriteRender.sprite = _saunaCharacterSpritesList[2];
        }
    }

    private void SaunaPlayerInput_OnAlternatePressed(object sender, System.EventArgs e)
    {
        if (SaunaManager.Instance.GetCurrentState() == STATE_IS_VIHTA)
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
    }

    private void SaunaPlayerInput_OnInteractionPressed(object sender, System.EventArgs e)
    {
        if (SaunaManager.Instance.GetCurrentState() == STATE_IS_WATER)
        { 
            
            _saunaCharacterSpriteRender.sprite = _saunaCharacterSpritesList[1];

            StartCoroutine(DelayedIE());
        }
    }

    IEnumerator DelayedIE()
    {
        yield return new WaitForSeconds(0.5f);

        _saunaCharacterSpriteRender.sprite = _saunaCharacterSpritesList[0];
    }
}
