using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public bool forwards;
    public float speed;

    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void ApplyRotation()
    {
        transform.localRotation = Quaternion.Euler(-90, 0, 180);
    }
    // Update is called once per frame
    void Update()
    {
        if (forwards)
        {
            rb.linearVelocity = new Vector3(0, 0, speed);
        }
        else
        {
            rb.linearVelocity = new Vector3(0, 0, -speed);
        }
    }
}
