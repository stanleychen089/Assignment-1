using UnityEngine;

public class PanickDucks : MonoBehaviour
{

    //a public reference to moon's position 
    public Transform moonPos;

    public float duckSpeed;

    //vectors used to check for screen border 
    Vector2 bottomLeft;
    Vector2 topRight;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //code from 2-4 readings, which converts screen coordinate as world coordinate so code adjusts to different world sizes 
        bottomLeft = Camera.main.ScreenToWorldPoint(Vector2.zero);
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        //random position 
        transform.position = new Vector2(Random.Range(-5, 5),-4);
    }

    // Update is called once per frame
    void Update()
    {

        //a vector to obtain the moon's x position 
        Vector2 moonDistance = moonPos.position;

        //speed increases when moon is closer to centre 
        //random adds a jitter effect to simulate swimming 
        duckSpeed = (Random.Range(9,11) + moonDistance.x);

        //vector that obtains duck's x position to move it 
        Vector2 newPos = transform.position;
        newPos.x += duckSpeed * Time.deltaTime*2;

         //code from 2-4 from readings, which checks of object is at the edge of the screen
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if(screenPos.x > Screen.width +1)
        {
            newPos.x = bottomLeft.x - 1;
            
        }

        transform.position = newPos;

    }
}
