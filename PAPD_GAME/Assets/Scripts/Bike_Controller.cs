using UnityEngine;
using UnityEngine.InputSystem;

public class Bike_Controller : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce;
    public float sideForce;

    public float maxFront;
    public float maxSide;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
        {
            rb.AddForce((new Vector3(0, 0, forwardForce)));
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(-sideForce, 0, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(0, 0, -forwardForce / 2));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(sideForce, 0, 0));
        }
    }
}
