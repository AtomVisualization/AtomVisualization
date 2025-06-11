using System.Collections;
using System.Collections.Generic;
using System.Data;
using Oculus.Interaction;
using Oculus.Interaction.Demo;
using Oculus.Interaction.HandGrab;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;
using System;




public class Chlorine_Success : MonoBehaviour
{

    private float count;
   
    public GameObject next;

    public float count3;
    

    private const string TAG_MNGR_ASSET = "ProjectSettings/TagManager.asset";






    public void stort1(GameObject Chlor, float count2)
    {

        check2(Chlor, count2);
    }

    void check2(GameObject Chlor, float count2)
    {
        
        //count = detection.count;
        if (count2 >= 3)
        {
            Debug.Log("Success");
            //detection.count = 0;
            count3 = 0;
            Debug.Log(count2);
            Stort(Chlor);
            

        }
    }


    void Stort(GameObject Chlor)
    {
        float count4 = detection.count2;
        GameObject[] waters = GameObject.FindGameObjectsWithTag("Chlor_" + count4);



        foreach (GameObject water in waters)
        {
            water.transform.SetParent(Chlor.transform);
            water.GetComponent<Grabbable>().enabled = false;
            water.GetComponent<GrabInteractable>().enabled = false;
            water.GetComponent<HandGrabInteractable>().enabled = false;
            water.GetComponentInChildren<SphereCollider>().enabled = false;
            water.transform.Find("Sphere 2").GetComponent<SphereCollider>().enabled = false;
            water.transform.Find("Sphere").GetComponent<SphereCollider>().enabled = false;
            water.transform.tag = "water3";

        }

        Chlor.GetComponent<Grabbable>().enabled = true;
        Chlor.GetComponent<GrabInteractable>().enabled = true;
        Chlor.GetComponent<HandGrabInteractable>().enabled = true;


        next.SetActive(true);

    }


}
    




