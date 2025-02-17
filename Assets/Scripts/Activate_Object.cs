using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_Object : MonoBehaviour
{
 public GameObject Activate;
 public GameObject[] Deactivate;

 public void ActivateObject() 
 {
    foreach (GameObject obj in Deactivate) 
    {
        obj.SetActive(false);
    }

   if (Activate.activeSelf != true) 
   {
    Activate.SetActive(true);
    
   }

   else
   {
    Activate.SetActive(false);
   }
 }
}
