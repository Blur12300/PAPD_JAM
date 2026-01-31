using UnityEngine;

public class Curb : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if ( (other.CompareTag("Player")))
        {
            Debug.Log("You died");
        }
    }
}
