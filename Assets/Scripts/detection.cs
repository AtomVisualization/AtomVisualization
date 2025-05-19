using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class detection : MonoBehaviour
{

    public static float count = 0;
    public string newTag = "water";
    public string oldTag = "H2O";


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sodium"))
        {
            this.transform.parent.tag = newTag;
            count = count + 1;
            Debug.Log(count);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Sodium"))
        {
            this.transform.parent.tag = oldTag;
            count = count - 1;
        }
    }
}


