using Unity.VisualScripting;
using UnityEngine;

public class FloatingOnTheOcean1 : MonoBehaviour
{
    public float speed = 0f;
    public AnimationCurve curve;
    public Transform start; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed += Time.deltaTime;
        if (speed > 1)
        {
            speed = 0; 
        }
        Vector2 newPos = transform.position;
        newPos.y = newPos.y + speed;
      //  transform.position = Vector2.Lerp(start, newPos.y, curve.Evaluate(speed));
    }
}
