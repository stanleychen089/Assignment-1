using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public Sprite[] barrels; 
    public int randomNumber = 0; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PickARandomColor();
        PickARandomSprite();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            // PickARandomColor();
            PickARandomSprite();
        }
        if (Mouse.current.leftButton.isPressed)
        {
            // PickARandomColor(); 
            PickARandomSprite();

        }

        //spriteRenderer.sprite.bounds.Contains(mousePos) Only checks for (0,0,0) DO NOT USE 
        //spriteRenderer.bounds.Contains(mousePos) Correct position of desired gameObject 

        //get the mouse position in the world 
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //check if mouse position is over sprite
        if (spriteRenderer.bounds.Contains(mousePos))
            {
            //Y: Use col variable
            spriteRenderer.color = col; 
        }
        else
        {
            spriteRenderer.color = Color.white;
            //N: Set the color to white 
        }

    }

    void PickARandomColor()
    {
        spriteRenderer.color = Random.ColorHSV();

    }

    void PickARandomSprite()
    {
        //get a random number between 0 and 2
        randomNumber = Random.Range(0, barrels.Length);
        //use the random number to set the sprite 
       spriteRenderer.sprite = barrels[randomNumber];


    }
}
