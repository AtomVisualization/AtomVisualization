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




public class Sodium_Success : MonoBehaviour
{

    private float count;
   
    public GameObject next;

    public float count3;
    

    private const string TAG_MNGR_ASSET = "ProjectSettings/TagManager.asset";






    public void stort1(GameObject Sod, float count2, string tag1)
    {

        check2(Sod, count2, tag1);
    }

    void check2(GameObject Sod, float count2, string tag1)
    {
        
        //count = detection.count;
        if (count2 >= 3)
        {
            Debug.Log("Success");
            //detection.count = 0;
            count3 = 0;
            Debug.Log(count2);
            Stort(Sod, tag1);
            

        }
    }


    void Stort(GameObject Sod, string tag1)
    {
        float count4 = detection.count2;
        GameObject[] waters = GameObject.FindGameObjectsWithTag(tag1);

        Debug.Log("sodium " + tag1);

        foreach (GameObject water in waters)
        {
            water.transform.SetParent(Sod.transform);
            water.GetComponent<Grabbable>().enabled = false;
            water.GetComponent<GrabInteractable>().enabled = false;
            water.GetComponent<HandGrabInteractable>().enabled = false;
            water.GetComponentInChildren<SphereCollider>().enabled = false;
            water.transform.Find("Sphere 2").GetComponent<SphereCollider>().enabled = false;
            water.transform.Find("Sphere").GetComponent<SphereCollider>().enabled = false;
            water.transform.tag = "water3";

        }

       Sod.GetComponent<Grabbable>().enabled = true;
        Sod.GetComponent<GrabInteractable>().enabled = true;
       Sod.GetComponent<HandGrabInteractable>().enabled = true;


        next.SetActive(true);

    }


}
    




