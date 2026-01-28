using UnityEngine;

public class BouncingBallExercise : MonoBehaviour
{
    public float speedX = 0.01f;
    public float speedY = 0.01f;

    //randomizes starting position
    float startingPosition = Random.Range(-5, 5);


    Vector2 bottomLeft;
    Vector2 topRight;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = (Vector2) transform.position + Random.insideUnitCircle * 5;
        bottomLeft = Camera.main.ScreenToWorldPoint(Vector2.zero);
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        newPos.x = startingPosition;
        newPos.x += speedX * Time.deltaTime; 
        newPos.y += speedY * Time.deltaTime;

        //check if the object is at the edge of the screen
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position); 
        //test for left edge
        if(screenPos.x < 0)
        {
            //set our position to be the world space position under pixel 0 in x
            
            newPos.x = bottomLeft.x;
            speedX = speedX * -1; 
        }

        //test for right edge
        if (screenPos.x > Screen.width)
        {
            //set our position to be the world space position under pixel Screen.width in x

            newPos.x = topRight.x; 
            speedX = speedX * -1;
        }
        if(screenPos.y < 0)
        {
            //set our position to be the world space position under pixel 0 in y
            
            newPos.y = bottomLeft.y;
            speedY = speedY * -1; 
        }

        //test for right edge
        if (screenPos.y > Screen.height)
        {
            //set our position to be the world space position under pixel Screen.width in y

            newPos.y = topRight.y; 
            speedY = speedY * -1;
        }

        transform.position = newPos;

    }
}
