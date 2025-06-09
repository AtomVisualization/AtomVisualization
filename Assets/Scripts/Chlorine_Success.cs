using System.Collections;
using System.Collections.Generic;
using System.Data;
using Oculus.Interaction;
using Oculus.Interaction.Demo;
using Oculus.Interaction.HandGrab;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;


public class Chlorine_Success : MonoBehaviour
{

    private float count;
    private detection detect;
    public GameObject next;

    public float count3;






    public void stort1(GameObject Chlor)
    {

        check2(Chlor);
    }

    void check2(GameObject Chlor)
    {
        count = detection.count;
        Debug.Log("Current count3: " + count3);
        if (count >= 3)
        {
            Debug.Log("Success");


            Stort(Chlor);
            Debug.Log(count);

        }
    }


    void Stort(GameObject Chlor)
    {
        GameObject[] waters = GameObject.FindGameObjectsWithTag("water2C");



        foreach (GameObject water in waters)
        {
            water.transform.SetParent(Chlor.transform);
            water.transform.tag = "water3";
            // Optionally delay disabling components to ensure all events fire




            water.GetComponent<Grabbable>().enabled = false;
            water.GetComponent<GrabInteractable>().enabled = false;
            water.GetComponent<HandGrabInteractable>().enabled = false;
            water.GetComponentInChildren<SphereCollider>().enabled = false;


        }

         Chlor.GetComponent<Grabbable>().enabled = true;
        Chlor.GetComponent<GrabInteractable>().enabled = true;
        Chlor.GetComponent<HandGrabInteractable>().enabled = true;

        Debug.Log("Chlorine success reset");
        next.SetActive(true);
    }
    //stuff below was originally in Stort, but calling a new function
    






}


    




