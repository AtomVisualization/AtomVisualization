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
   
  
   



    public void stort1(GameObject Chlor)
    {
        check2(Chlor);
    }

    void check2(GameObject Chlor)
    {
        count = detection.count;

        if (count >= 3)
        {
            Debug.Log("Success");
            detection.count = 0;
        
            Stort(Chlor);

        }
    }


        void Stort(GameObject Chlor)
    {
        GameObject[] waters = GameObject.FindGameObjectsWithTag("water");
        count = detection.count;



        foreach (GameObject water in waters)
        {
            water.transform.SetParent(Chlor.transform);
            water.GetComponent<Grabbable>().enabled = false;
            water.GetComponent<GrabInteractable>().enabled = false;
            water.GetComponent<HandGrabInteractable>().enabled = false;
            water.GetComponentInChildren<SphereCollider>().enabled = false;
             water.transform.tag = "water2";
        }
        
            

           Chlor.GetComponent<Grabbable>().enabled = true;
            Chlor.GetComponent<GrabInteractable>().enabled = true;
          Chlor.GetComponent<HandGrabInteractable>().enabled = true;
         


        Debug.Log("Chlorine " + count);
        next.SetActive(true);


    }
}

    




