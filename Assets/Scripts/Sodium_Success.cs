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
    public void stort1(GameObject Sod)
    {
        check2(Sod);
    }

    void check2(GameObject Sod)
    {
        count = Detection2.count;

        if (count >= 3)
        {
            Debug.Log("Success");
            Detection2.count = 0;
            Stort(Sod);
        }
    }


    void Stort(GameObject Sod)
    {
        Debug.Log("stort");
        GameObject sodium = GameObject.FindGameObjectWithTag("Sodium");
        GameObject[] waters = GameObject.FindGameObjectsWithTag("water");
        count = Detection2.count;



        foreach (GameObject water in waters)
        {
            water.transform.SetParent(Sod.transform);
            water.GetComponent<Grabbable>().enabled = false;
            water.GetComponent<GrabInteractable>().enabled = false;
            water.GetComponent<HandGrabInteractable>().enabled = false;
            water.GetComponentInChildren<SphereCollider>().enabled = false;
            water.transform.tag = "water2";
        }
        
            

            Sod.GetComponent<Grabbable>().enabled = true;
            Sod.GetComponent<GrabInteractable>().enabled = true;
            Sod.GetComponent<HandGrabInteractable>().enabled = true;
            


        Debug.Log("Sodium " + count);
       



    }

}

    


