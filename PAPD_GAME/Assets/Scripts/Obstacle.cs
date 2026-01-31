using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject explosion;
    public GameObject obstacle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(obstacle);
            GameObject exp = GameObject.Instantiate(explosion);

            exp.transform.SetParent(transform);
            exp.transform.localPosition = Vector3.zero;
        }
    }
}
