using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCustomer : MonoBehaviour
{
    // Start is called before the first frame update
   
    public GameObject Customer;

    public bool stopSpawing = false;
    public float spawnTime;
    public float spawnDelay;

    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }


    public void SpawnObject()
    {
        Instantiate(Customer, transform.position, transform.rotation);
        if (stopSpawing)
        {
            CancelInvoke("SpawnObjects");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    
}
