
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnikkersSpawn : MonoBehaviour
{
    public GameObject junkFood1, junkFood2, junkFood3, junkFood4, healthyFood1, healthyFood2, healthyFood3, healthyFood4;

    public float spawnRate = 2f;

    float nextSpawn = 0f;

    int whatToSpawn;

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            whatToSpawn = Random.Range(1, 8);
            Debug.Log(whatToSpawn);

            switch (whatToSpawn) {
                case 1:
                    Instantiate(junkFood1, transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(junkFood2, transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(junkFood3, transform.position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(junkFood4, transform.position, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(healthyFood1, transform.position, Quaternion.identity);
                    break;
                case 6:
                    Instantiate(healthyFood2, transform.position, Quaternion.identity);
                    break;
                case 7:
                    Instantiate(healthyFood3, transform.position, Quaternion.identity);
                    break;
                case 8:
                    Instantiate(healthyFood4, transform.position, Quaternion.identity);
                    break;
            }
            nextSpawn = Time.time + spawnRate;
        }     
    }
}
