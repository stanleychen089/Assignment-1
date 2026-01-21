using UnityEngine;

public class RotatingClockHands : MonoBehaviour
{
    public float speed; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 hourHandRotation = transform.eulerAngles;
        hourHandRotation.z += speed * Time.deltaTime;
        transform.eulerAngles = hourHandRotation;

    }
}
