using UnityEngine;

public class Curb : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if ( (other.CompareTag("Player")))
        {
            Debug.Log("You died");
        }
    }
}
