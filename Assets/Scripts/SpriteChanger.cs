using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PickARandomColor();

    }

    // Update is called once per frame
    void Update()
    {
        //if (Keyboard.current.anyKey.wasPressedThisFrame)
        //{
        //   // PickARandomColor();
        //}
        //if (Mouse.current.leftButton.isPressed)
        //{
        //   // PickARandomColor(); 
        //}

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
}
