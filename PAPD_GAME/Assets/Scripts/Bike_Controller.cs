using UnityEngine;
using UnityEngine.InputSystem;

public class Bike_Controller : MonoBehaviour
{
    public CharacterController cc;
    public float frontSpeed;
    public float sideSpeed;

    public float maxFront;
    public float maxSide;

    public float accel = 1.02f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
        {
            cc.Move(new Vector3(0, 0, frontSpeed));
            if (frontSpeed < maxFront)
            {
                frontSpeed = frontSpeed * accel;
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            cc.Move(new Vector3(-sideSpeed, 0, 0));
            if (sideSpeed < maxSide)
            {
                sideSpeed = sideSpeed * accel;
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            cc.Move(new Vector3(0, 0, -frontSpeed));
            if (frontSpeed < maxFront)
            {
                frontSpeed = frontSpeed * accel;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            cc.Move(new Vector3(sideSpeed, 0, 0));
            if (sideSpeed < maxSide)
            {
                sideSpeed = sideSpeed * accel;
            }
        }
        
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S)) 
        {
            frontSpeed = 1f;
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            sideSpeed = 0.5f;
        }

    }
}
