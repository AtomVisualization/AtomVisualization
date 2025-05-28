using Oculus.Interaction.HandGrab;
using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chlorine_Success : MonoBehaviour
{

    private float count;
    public Detection2 detect;
  
   



    public void stort1()
    {
        Invoke("check2", 1);
    }

    void check2()
    {
        count = detection.count;

        if (count >= 6)
        {
            Debug.Log("Success");
            count = 0;
            Stort();

        }
    }


    void Stort()
    {
        GameObject chlorine = GameObject.FindGameObjectWithTag("Chlorine");


        if (this.tag == "water")
        {
            this.transform.SetParent(chlorine.transform);
            this.GetComponent<Grabbable>().enabled = false;
            this.GetComponent<GrabInteractable>().enabled = false;
            this.GetComponent<HandGrabInteractable>().enabled = false;
            this.GetComponent<DistanceGrabInteractable>().enabled = false;

            chlorine.GetComponent<Grabbable>().enabled = true;
            chlorine.GetComponent<GrabInteractable>().enabled = true;
            chlorine.GetComponent<HandGrabInteractable>().enabled = true;
            chlorine.GetComponent<DistanceGrabInteractable>().enabled = true;

            detect.ResetCounter();
        }






    }
}

    




