using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject explosion;
    public GameObject obstacle;
    PizzaHealth ph;

    void Start()
    {
        ph = GameObject.FindWithTag("Pizza").GetComponent<PizzaHealth>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(obstacle);
            GameObject exp = GameObject.Instantiate(explosion);

            exp.transform.SetParent(transform);
            exp.transform.localPosition = Vector3.zero;
            ph.LowerHealth();

        }
    }
}
