using UnityEngine;
using UnityEngine.InputSystem;

public class Controls : MonoBehaviour
{
    public bool leftMouseIsPressed = false; 
    public bool rightMouseIsPressed = false;
    public bool anyKeyIsPressed = false;

    public float speed = 6;
    public float rotationSpeed = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Mouse position: Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue())

        //isPressed is a function that sets the boolean to true all the time if the button is pressed
        leftMouseIsPressed = Mouse.current.leftButton.isPressed;
        rightMouseIsPressed = Mouse.current.rightButton.isPressed;


        //wasPressedThisFrame is a function that sets the boolean to true the first time the button is prreesed (Once) 
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Debug.Log("Left Button Pressed");
        }
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            Debug.Log("Right Button Pressed");
        }

        //keyboard
        anyKeyIsPressed = Keyboard.current.anyKey.isPressed;

        //test for left arrow key: move to left
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            Vector2 newPos = transform.position;
            newPos.x -= speed * Time.deltaTime;
            transform.position = newPos;
        }
        //test for right arrow key: move to right
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            Vector2 newPos = transform.position;
            newPos.x += speed * Time.deltaTime;
            transform.position = newPos;
        }
        //test for up arrow key: move to up
        if (Keyboard.current.upArrowKey.isPressed)
        {
            transform.position += transform.up * speed * Time.deltaTime; 
        }
        //test for down arrow key: move to down
        if (Keyboard.current.downArrowKey.isPressed)
        {
            transform.position -= transform.up * speed * Time.deltaTime;

        }

        //rotation to direction
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            Vector3 newRotation = transform.eulerAngles;
            newRotation.z += rotationSpeed * Time.deltaTime;
            transform.eulerAngles = newRotation;
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            Vector3 newRotation = transform.eulerAngles;
            newRotation.z -= rotationSpeed * Time.deltaTime;
            transform.eulerAngles = newRotation;
        }
        
    }
}
