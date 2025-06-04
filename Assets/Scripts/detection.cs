using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detection : MonoBehaviour
{

    public static float count = 0;
    public string newTag = "water";
    public string oldTag = "H2O";
    private bool debounce = false;
 


    private void OnTriggerEnter(Collider other)
    {
        if (debounce == true)
        {
            return;
        }
        if (other.CompareTag("Chlorine") || other.CompareTag("salt"))
        {
            this.transform.parent.tag = newTag;
            count = count + 1;
            Debug.Log(count);

           
            debounce = true;

            other.GetComponent<Chlorine_Success>().stort1(other.GetComponentInParent<Transform>().gameObject);

            Invoke("ResetCounter", 0.5f);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Chlorine"))
        {

            count = count - 1;
        }
    }

    public void ResetCounter()
    {
        debounce = false;
    }

}


