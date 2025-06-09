using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection2 : MonoBehaviour
{
    public static float count = 0;
    public string newTag = "water";
    public string oldTag = "H2O";
    private bool debounce = false;



    public void OnTriggerEnter(Collider other)
    {
        if (debounce == true)
        {
            return;
        }
        if (other.CompareTag("Sodium") || other.CompareTag("salt"))
        {
            if (count < 0)
            {
                count = 0;
            }

            this.transform.parent.tag = newTag;
            count = count + 1;
            Debug.Log(count);

            debounce = true;


            other.GetComponent<Sodium_Success>().stort1(other.GetComponentInParent<Transform>().gameObject);

            Invoke("ResetCounter", 0.5f);


        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Sodium"))
        {
            //count = count - 1;
            
        }
    }

    public void ResetCounter()
    {
        debounce = false;
    }

    public void OnReset()
    {

    }

}

