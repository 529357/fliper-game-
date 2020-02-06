using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OntriggerDSTR : MonoBehaviour
{
   
    void Start()
    {
        
    }

  
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FatBall"))
        {
            Destroy(other.gameObject);
        }
    }

    private void nTriggerEnter(Collider other)
    {
        if (other.CompareTag("HealthyBall"))
        {
            Destroy(other.gameObject);
        }
    }
}
