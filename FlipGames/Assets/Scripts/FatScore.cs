using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FatScore : MonoBehaviour
{
    public static int scorevalue;
    Text fatScore;

    void Start()
    {
        fatScore = GetComponent<Text>();
    }

  
    void Update()
    {
        fatScore.text = "Fat" + scorevalue;
    }
}
