using UnityEngine;

public class Hitable_Person : MonoBehaviour
{

    public GameObject person;
    public GameObject ragdoll;

    Rigidbody rb;

    public float hitForce;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject.Destroy(person);
            gameObject.GetComponent<BoxCollider>().enabled = false;

            GameObject rag = GameObject.Instantiate(ragdoll);
            rag.transform.SetParent(gameObject.transform, false);
            rag.transform.localPosition = Vector3.zero;

            rb = rag.GetComponent<Rigidbody>();
            rb.freezeRotation = false;
            rb.AddForce(new Vector3(0, hitForce/2, hitForce));
        }
    }
}
