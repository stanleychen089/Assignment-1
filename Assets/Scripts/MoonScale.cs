using UnityEngine;
using UnityEngine.InputSystem;

public class MoonScale : MonoBehaviour
{

    // a boolean value to see if mouse is hovering over the moon (object)
    public bool mouseOverMoon;
    public float timer = 1;
    public float moonHitbox = 0.5f; 

    //start position for Lerp() 
    public Transform startPos;
    public Transform endPos; 
    public float moonSpeed = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
        //get mouse position and convert its position from the screen in pixels to a position in the world in meters 
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //get the distance between moon object and mouse 
        float distance = Vector2.Distance(transform.position, mousePos);
        

        //condition statement to see if distance is less than 1 to determine if mouseOverMoon is true or false 
        if (distance < moonHitbox)
        {
            mouseOverMoon = true;
        }
        else
        {
            mouseOverMoon = false;
        }

        //a condition that activates if mouseOverMoon is true 
        //if true, the transform object will increase in size and stuff
        // a timer variable that starts increasing when mouse is over moon, which will be used to increase moon size.
        // Timer will start decreasing when mouse is not over moon
        if (mouseOverMoon)
        {
            timer += Time.deltaTime*0.1f;
            //mouses hitbox slowly increases when mouse is over moon
            moonHitbox = moonHitbox + Time.deltaTime*0.1f;

      
            moonSpeed += Time.deltaTime * 0.01f;

            

        }

        //timer starts counting down if mouse over moon is false and timer value is above 0, so timer cannot go below 0
        else if (mouseOverMoon == false && timer > 1)
        {
            timer -= Time.deltaTime * 0.5f;

            //if mouse is not over moon, mouse's hitbox decreases
            if (moonHitbox > 0.5f)
            {
                moonHitbox -= Time.deltaTime * 0.5f;
            }

            //if mouse is not over moon, moon will slowly return to starting position
            if (moonSpeed > 0)
            {
                moonSpeed -= Time.deltaTime*0.05f;
            }
            
            

        }

        //timer as a vector value so it can be used to increase newSize
        Vector2 scaleIncrease = Vector2.one * timer;

        //Moon size scales with timer 
        Vector2 newSize = transform.localScale * Time.deltaTime;
        newSize = newSize + scaleIncrease;
        transform.localScale = newSize;

        //Lerp for moon to move towards endPos 
        transform.position = Vector2.Lerp(startPos.position, endPos.position, moonSpeed);




    }
}
