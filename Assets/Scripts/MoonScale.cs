using UnityEngine;
using UnityEngine.InputSystem;

public class MoonScale : MonoBehaviour
{
    // a boolean value to see if mouse is hovering over the moon 
    //a public transform reference to a moon's hitbox to use for boolean calculation 
    public bool mouseOverMoon;
    public Transform moonHitbox; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    


    }

    // Update is called once per frame
    void Update()
    {
        //get mouse position and convert its position from the screen in pixels to a position in the world in meters 
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //get the distance between moonHitbox and mouse 
        float distance = Vector2.Distance(moonHitbox.position, mousePos);

        //condition statement to see if distance is less than 1 to determine if mouseOverMoon is true or false 
        if (distance < 0.5)
        {
            mouseOverMoon = true;
        }
        else
        {
            mouseOverMoon = false;
        }

        //a condition that activates if mouseOverMoon is true 
        //if true, the transform object will increase in size and stuff
        if (mouseOverMoon)
        {

        }
  
    }
}
