using System.Collections;
using System.Collections.Generic;
using System.Data;
using Oculus.Interaction;
using Oculus.Interaction.Demo;
using Oculus.Interaction.HandGrab;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

public class Sodium_Success : MonoBehaviour
{
    private float count;
    private Detection2 detect;




    // Update is called once per frame
    public void stort1()
    {
        check2();
    }

    void check2()
    {
        count = Detection2.count;

        if (count >= 3)
        {
            Debug.Log("Success");
            Stort();
        }
    }


    void Stort()
    {
        Debug.Log("stort");
        GameObject sodium = GameObject.FindGameObjectWithTag("Sodium");
        GameObject[] waters = GameObject.FindGameObjectsWithTag("water");
        count = Detection2.count;



        foreach (GameObject water in waters)
        {
            water.transform.SetParent(sodium.transform);
            water.GetComponent<Grabbable>().enabled = false;
            water.GetComponent<GrabInteractable>().enabled = false;
            water.GetComponent<HandGrabInteractable>().enabled = false;
            water.GetComponent<DistanceGrabInteractable>().enabled = false;
            water.transform.tag = "water2";
        }
        
            

            sodium.GetComponent<Grabbable>().enabled = true;
            sodium.GetComponent<GrabInteractable>().enabled = true;
            sodium.GetComponent<HandGrabInteractable>().enabled = true;
            sodium.GetComponent<DistanceGrabInteractable>().enabled = true;


        Debug.Log("Sodium " + count);
       



    }

}

    


