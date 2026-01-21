using UnityEditorInternal;
using UnityEngine;


public class DirectionalMovement : MonoBehaviour
{
    public float speed = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.right is an equivalent to 'new Vector3(1,0,0); 
        //transform.up is an equivalent to 'new Vector3(1,0, 0);
        //transform.forward is equivalent to 'new Vector3(0,0,1); which should not be used in 2D games 
        transform.position += transform.right * speed * Time.deltaTime; 
        transform.position += transform.up * speed * Time.deltaTime; 
    }
}
