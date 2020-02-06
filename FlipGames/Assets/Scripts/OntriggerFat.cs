using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OntriggerFat : MonoBehaviour
{
    public int fatPoints = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FatBall"))
        {
            fatPoints++;

            Destroy(other.gameObject);
        }
    }

    public void Update()
    {
        if (fatPoints >= 10)
        {
            SceneManager.LoadScene(sceneName: "You died");
        }
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "FatScore : " + fatPoints);
    }

}
