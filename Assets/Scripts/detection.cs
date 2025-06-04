using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detection : MonoBehaviour
{

    public static float count = 0;
    public string newTag = "water";
    public string oldTag = "H2O";
 


    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Chlorine") || other.CompareTag("salt"))
        {
            this.transform.parent.tag = newTag;
            count = count + 1;
            Debug.Log(count);

            if (count >= 4)
            {
                count = 0;
            }

            other.GetComponent<Chlorine_Success>().stort1();
            

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
        count = 0;
    }

}


