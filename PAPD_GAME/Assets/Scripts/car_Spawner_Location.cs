using UnityEngine;

public class car_Spawner_Location : MonoBehaviour
{
    public float distanceFromPlayer;
    public bool isForward;

    public GameObject player;
    // Update is called once per frame
    void Update()
    {
        if (isForward)
            transform.position = new Vector3(transform.position.x, transform.position.y, player.transform.position.z + distanceFromPlayer);
        else
            transform.position = new Vector3(transform.position.x, transform.position.y, player.transform.position.z - distanceFromPlayer);
    }
}
