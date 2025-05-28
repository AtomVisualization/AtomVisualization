using Oculus.Interaction.HandGrab;
using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public GameObject salt;

    private float count1;
    private float count2;
    public static bool already = false;

    public void res()
    {

        count1 = detection.count;
        count2 = Detection2.count;


        already = false;
        GameObject[] waters = GameObject.FindGameObjectsWithTag("water");
        GameObject[] salts = GameObject.FindGameObjectsWithTag("salt");

        foreach (GameObject salt in salts)
        {
            Destroy(salt);
        }

        foreach (GameObject water in waters)
        {
            Destroy(water);
        }
   
        Instantiate(salt);

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
