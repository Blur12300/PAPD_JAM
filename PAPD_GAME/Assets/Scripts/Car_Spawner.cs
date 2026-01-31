using UnityEngine;

public class Car_Spawner : MonoBehaviour
{
    public GameObject car;
    public GameObject frontSpawner;
    public GameObject backSpawner;
    public Transform endParent;

    public float timeDelay;
    public float count;
    public bool canSpawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //SpawnCar(true);
        //SpawnCar(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0, 175) == 67)
        {
            float ran2 = Random.value;
            if (ran2 >= 0.5 && canSpawn)
            {
                SpawnCar(true);
                count = 0;
            }
            else if (ran2 < 0.5 && canSpawn)
            {
                SpawnCar(false);
                count = 0;
            }
        }
        if (count <= timeDelay)
        {
            count += Time.deltaTime;
            canSpawn = false;
        }
        else
        {
            canSpawn = true;
        }

    }
    void SpawnCar(bool frontFacing)
    {
        if (frontFacing)
        {
            GameObject newCar = GameObject.Instantiate(car);
            newCar.transform.SetParent(backSpawner.transform);
            newCar.transform.localPosition = Vector3.zero;

            CarMovement cm = newCar.GetComponent<CarMovement>();
            cm.forwards = true;
            cm.ApplyRotation();

            newCar.transform.SetParent(endParent.transform);
        }
        else
        {
            GameObject newCar = GameObject.Instantiate(car);
            newCar.transform.SetParent(frontSpawner.transform);
            newCar.transform.localPosition = Vector3.zero;

            CarMovement cm = newCar.GetComponent<CarMovement>();
            cm.forwards = false;
            cm.ApplyRotation();

            newCar.transform.SetParent(endParent.transform);
        }
    }
}
