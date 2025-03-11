using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using static UnityEngine.UI.Image;

public class Deactivate_Object : MonoBehaviour
{
    public GameObject original1;
    public GameObject original2;
    public GameObject original3;
    public GameObject original4;
    public GameObject original5;
    public GameObject original6;
    public GameObject original7;


    public void Deactivate()
    {
        GameObject[] electrons = GameObject.FindGameObjectsWithTag("Electron");

        foreach (GameObject electron in electrons)
        {


            Destroy(electron);
            Debug.Log("Electron destroyed: " + electron.name);


        }
        Instantiate(original1);
        Instantiate(original2);
        Instantiate(original3);
        Instantiate(original4);
        Instantiate(original5);
        Instantiate(original6);
        Instantiate(original7);
    }
}
