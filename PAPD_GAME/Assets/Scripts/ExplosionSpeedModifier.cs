using UnityEngine;

public class ExplosionSpeedModifier : MonoBehaviour
{
    ParticleSystem ps;
    private Rigidbody playerRB;
    public float modifier = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        playerRB = GameObject.FindWithTag("Player").GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ps.startSpeed = modifier * playerRB.linearVelocity.z;
    }
}
