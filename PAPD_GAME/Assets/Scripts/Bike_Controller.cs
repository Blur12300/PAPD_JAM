using UnityEngine;
using UnityEngine.InputSystem;

public class Bike_Controller : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce;
    public float sideForce;

    public float maxFrontSpeed;
    public float maxSideSpeed;

    public Steering_Inputter si;

    public AudioSource AS;
    public float minPitch;
    public float maxPitch;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float lrAmount = si.GetLeftRight();
        float leftRightMult;

        leftRightMult = lrAmount / si.lockedRightLimit;

        Debug.Log(leftRightMult);

        if (Input.GetKey(KeyCode.W) && rb.linearVelocity.z < maxFrontSpeed)
        {
            rb.AddForce((new Vector3(0, 0, forwardForce)));
        }
        if (Input.GetKey(KeyCode.S) && rb.linearVelocity.z > -maxFrontSpeed)
        {
            rb.AddForce(new Vector3(0, 0, -forwardForce / 2)  );
        }

        if (rb.linearVelocity.z > 0 && rb.linearVelocity.x < maxSideSpeed)
        {
            rb.AddForce(new Vector3(leftRightMult * sideForce, 0, 0));  
        }
        AS.pitch = 1 + (rb.linearVelocity.z / maxFrontSpeed) * 2;
    }
}
