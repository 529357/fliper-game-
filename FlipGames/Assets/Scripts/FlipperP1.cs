using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperP1 : MonoBehaviour
{
    public float resPosition = 0f;
    public float pressedPostion = 45f;
    public float hitStrenght = 10000f;
    public float flipperDamper = 150f;

    public string inputName;

    private void Update()
    {
        if (Input.GetAxis(inputName) == 1)
        {

        }
    }
}