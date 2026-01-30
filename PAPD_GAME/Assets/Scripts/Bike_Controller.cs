using UnityEngine;
using UnityEngine.InputSystem;

public class Bike_Controller : MonoBehaviour
{
    public CharacterController cc;
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
        {

            cc.Move(new Vector3(0, 0, speed));
        }
    }
}
