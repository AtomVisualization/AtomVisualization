using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection2 : MonoBehaviour
{
    public static float count = 0;
    public string newTag = "water";
    public string oldTag = "H2O";
  


    private void OnTriggerEnter(Collider other)
    {
    
        if (other.CompareTag("Sodium") || other.CompareTag("salt"))
        {
            this.transform.parent.tag = newTag;
            count = count + 1;
            Debug.Log(count);

            if (count >= 4)
            {
                count = 0;
            }
            
            other.GetComponent<Sodium_Success>().stort1();

           
            

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Sodium"))
        {

            count = count - 1;
        }
    }

    public void ResetCounter()
    {
        count = 0;
    }

}

