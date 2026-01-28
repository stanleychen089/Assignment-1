using UnityEngine;
using UnityEngine.InputSystem;

public class MoonPulse : MonoBehaviour
{
    public AnimationCurve curve;
    public float t = 0;

    public float moonHitbox = 0.5f;

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


        //moon pulses when mouse is over the object 
        if (distance < moonHitbox)
        {
            moonHitbox = moonHitbox + Time.deltaTime * 0.1f;
            t += Time.deltaTime;
            if (t > 1)
            {
                t = 0;
            }
            transform.localScale = Vector2.one * curve.Evaluate(t);
        }
        else
        {
            t = 0;
            if (moonHitbox > 0.5f)
            {
                moonHitbox -= Time.deltaTime * 0.5f;
            }
        }

    }
}
