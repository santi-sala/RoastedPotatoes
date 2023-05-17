using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPoses : MonoBehaviour
{
    public static CharacterPoses Instance { get; private set; }

    [SerializeField] private Sprite[] _characterPoses;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    public void CahangeCharacterPose(bool fail, int flipPose, int characterPose = 0)
    {
        if (fail)
        {             
            _spriteRenderer.sprite = _characterPoses[_characterPoses.Length - 1];
            if (flipPose == 0)
            {
                _spriteRenderer.flipX = true;
                //Debug.Log("flipped");
            }
            else
            {
                _spriteRenderer.flipX = false;
            }

        }
        else
        {
            _spriteRenderer.sprite = _characterPoses[characterPose];
            if (flipPose == 0)
            {
                _spriteRenderer.flipX = true;
            }
            else
            {
                _spriteRenderer.flipX = false;
            }
        }
        
    }


}
