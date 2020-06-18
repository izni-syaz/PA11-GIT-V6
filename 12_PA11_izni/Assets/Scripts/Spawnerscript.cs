using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject SpawnObject;
    public GameObject[] spawnee;
    private float spawntime = 1;
    private float spawndelay = 1;
    private int randomInt;
    float PositionY;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", spawntime, spawndelay);
        
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    void SpawnObjects()
    {
        randomInt = Random.Range(0, spawnee.Length);
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        Instantiate(spawnee[randomInt], transform.position, transform.rotation);
    }
}
