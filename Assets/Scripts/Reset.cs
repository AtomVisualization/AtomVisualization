using Oculus.Interaction.HandGrab;
using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Reset : MonoBehaviour
{
    public GameObject salt;
    public GameObject water;

    private float count1;
    private float count2;
    public static bool already = false;

    public void res()
    {


        count2 = Detection2.count;


        already = false;
        GameObject[] waters = GameObject.FindGameObjectsWithTag("water");
        GameObject[] salts = GameObject.FindGameObjectsWithTag("salt");
        GameObject[] waters2 = GameObject.FindGameObjectsWithTag("H2O");
        GameObject[] waters3 = GameObject.FindGameObjectsWithTag("water2");

        foreach (GameObject salt in salts)
        {
            Destroy(salt);
        }

        foreach (GameObject water in waters)
        {
            Destroy(water);
        }

        foreach (GameObject H2 in waters2)
        {
            Destroy(H2);
        }

        foreach (GameObject water in waters3)
        {
            Destroy(water);
        }

        Instantiate(salt);
        Instantiate(water);

        GameObject Sodium = GameObject.FindGameObjectWithTag("Sodium");
        GameObject chlorine = GameObject.FindGameObjectWithTag("Chlorine");

        Sodium.GetComponent<Grabbable>().enabled = false;
        Sodium.GetComponent<GrabInteractable>().enabled = false;
        Sodium.GetComponent<HandGrabInteractable>().enabled = false;
        Sodium.GetComponent<DistanceGrabInteractable>().enabled = false;

        chlorine.GetComponent<Grabbable>().enabled = false;
        chlorine.GetComponent<GrabInteractable>().enabled = false;
        chlorine.GetComponent<HandGrabInteractable>().enabled = false;
        chlorine.GetComponent<DistanceGrabInteractable>().enabled = false;

    }
}
