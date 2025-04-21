using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Activate_Object : MonoBehaviour
{
    public GameObject Activate;
    public GameObject Activate2;
    public GameObject[] Deactivate;
    public GameObject original;
    private float spawnx = 0.4237f;
    private float spawny = 1.4269f;
    private float spawnz = 0.26f;

    

    public void ActivateObject()
    {

        
        foreach (GameObject obj in Deactivate)
        {
            obj.SetActive(false);
        }

        if (Activate.activeSelf != true)
        {
            Activate.SetActive(true);
            Activate2.SetActive(true);

        }

        else
        {
            Activate.SetActive(false);
             Activate2.SetActive(false);
        }

        Vector3 pos = new Vector3(spawnx, spawny, spawnz);

        GameObject[] electrons = GameObject.FindGameObjectsWithTag("Electron");

        // Loop through all the found objects and destroy them
        foreach (GameObject electron in electrons)
        {


            Destroy(electron);
            Debug.Log("Electron destroyed: " + electron.name);


        }
        Instantiate(original, pos, Quaternion.identity);
    }

    public void remove_Electrons()
    {

    }
}

