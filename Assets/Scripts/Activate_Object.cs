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
        

        // deactivates all objects in the list
        foreach (GameObject obj in Deactivate)
        {
            obj.SetActive(false);
        }
        // if the electron you press is not already there it makes it appear
        if (Activate.activeSelf != true)
        {
            Activate.SetActive(true);
            Activate2.SetActive(true);

            GameObject[] rings = GameObject.FindGameObjectsWithTag("Rings");
            foreach (GameObject ring in rings)
            {
                ring.SetActive(false);
            }

        }
        // if it's there it makes it dissapear 
        else
        {
            Activate.SetActive(false);
             Activate2.SetActive(false);
        }

       
        // position for the electron in electron sim
        Vector3 pos = new Vector3(spawnx, spawny, spawnz);

        // gets all the electrons in the scene
        GameObject[] electrons = GameObject.FindGameObjectsWithTag("Electron");

        // Loop through all the found objects and destroy them
        foreach (GameObject electron in electrons)
        {


            Destroy(electron);
            Debug.Log("Electron destroyed: " + electron.name);


        }
        // puts an electron in the original position 
        Instantiate(original, pos, Quaternion.identity);
    }

}

