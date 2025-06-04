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
   
  
   



    public void stort1()
    {
        Invoke("check2", 1);
    }

    void check2()
    {
        count = detection.count;

        if (count >= 3)
        {
            Debug.Log("Success");
        
            Stort();

        }
    }


        void Stort()
    {
        GameObject chlorine = GameObject.FindGameObjectWithTag("Chlorine");
        GameObject[] waters = GameObject.FindGameObjectsWithTag("water");
        count = detection.count;



        foreach (GameObject water in waters)
        {
            water.transform.SetParent(chlorine.transform);
            water.GetComponent<Grabbable>().enabled = false;
            water.GetComponent<GrabInteractable>().enabled = false;
            water.GetComponent<HandGrabInteractable>().enabled = false;
            water.GetComponent<DistanceGrabInteractable>().enabled = false;
             water.transform.tag = "water2";
        }
        
            

           chlorine.GetComponent<Grabbable>().enabled = true;
            chlorine.GetComponent<GrabInteractable>().enabled = true;
            chlorine.GetComponent<HandGrabInteractable>().enabled = true;
            chlorine.GetComponent<DistanceGrabInteractable>().enabled = true;


        Debug.Log("Chlorine " + count);


    }
}

    




