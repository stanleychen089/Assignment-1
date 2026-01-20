using UnityEngine;
using UnityEngine.InputSystem;

public class Rollover : MonoBehaviour
{
    public bool mouseIsOverMe = false;
    //Reading Bool 2-1 -> Booleans and using mouse position 
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //mini psuedocode 
        //get the mouse position (in pixels) and convert it to world position (in meters) 
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //get distance between transform.position and mouse position 
        float distance = Vector2.Distance(transform.position, mousePos);
        //if distance between is small, then mouseIsOverMe will be true; will be false otherwise 
        if (distance < 1)
        {
            mouseIsOverMe = true;
        }
        else
        {
            //otherwise is false
            mouseIsOverMe = false;
        }
    }
}
