using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatKnikker : MonoBehaviour
{

    public int fatPoints = 0;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "FatScore : " + fatPoints);
    }
}
