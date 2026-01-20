using UnityEngine;

public class BouncingBallExercise : MonoBehaviour
{
    public float speedX = 0.01f;
    public float speedY = 0.01f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = (Vector2) transform.position + Random.insideUnitCircle * 5; 
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        newPos.x += speedX; 
        newPos.y += speedY;
        transform.position = newPos;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position); 
        if(screenPos.x < 0 || screenPos.x > Screen.width)
        {
            speedX = speedX * -1; 
        }
        if(screenPos.y < 5 || screenPos.y > Screen.height)
        {
            speedY = speedY * -1;
        }
    }
}
