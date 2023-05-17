using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drinking_SpriteSwap : MonoBehaviour
{
    public List<Sprite> sprites;

    Sprite currentSprite;

    [SerializeField] float startingTime = 1f;
    [SerializeField] float currentTime = 0f;

    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;

        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
        }
        else if (currentTime <= 0)
        {
            currentTime = startingTime;
            
            SwapRandomSprite();
        }
    }

    void SwapRandomSprite()
    {
        currentSprite = sprites[Random.Range(0, sprites.Count)];

        spriteRenderer.sprite = currentSprite;
    }
}
