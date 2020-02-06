using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OthersideFat : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FatBall"))
        {
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("WeightBall"))
        {
            Destroy(other.gameObject);
        }
    }
}
