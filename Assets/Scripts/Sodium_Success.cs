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
    private detection detect;
    public GameObject next;

    public float count3;
    

    private const string TAG_MNGR_ASSET = "ProjectSettings/TagManager.asset";






    public void stort1(GameObject Sod, float count2)
    {

        check2(Sod, count2);
    }

    void check2(GameObject Sod, float count2)
    {
        
        //count = detection.count;
        if (count2 >= 3)
        {
            Debug.Log("Success");
            //detection.count = 0;
            count3 = 0;
            Debug.Log(count2);
            Stort(Sod);
            

        }
    }


    void Stort(GameObject Sod)
    {
        float count4 = detection.count2;
        GameObject[] waters = GameObject.FindGameObjectsWithTag("Sod_" + count4);



        foreach (GameObject water in waters)
        {
            water.transform.SetParent(Sod.transform);
            water.GetComponent<Grabbable>().enabled = false;
            water.GetComponent<GrabInteractable>().enabled = false;
            water.GetComponent<HandGrabInteractable>().enabled = false;
            water.GetComponentInChildren<SphereCollider>().enabled = false;
            water.transform.Find("Sphere").GetComponent<SphereCollider>().enabled = false;
            water.transform.Find("Sphere 2").GetComponent<SphereCollider>().enabled = false;
            water.transform.tag = "water";

        }

        Sod.GetComponent<Grabbable>().enabled = true;
        Sod.GetComponent<GrabInteractable>().enabled = true;
        Sod.GetComponent<HandGrabInteractable>().enabled = true;


        next.SetActive(true);

    }


}
    






