using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using Oculus.Interaction;

public class Electron_Remover : MonoBehaviour
{
    GameObject[] clones = GameObject.FindGameObjectsWithTag("destroy");

   public void bye()
   {
    foreach(GameObject Clone in clones) {
        Destroy(Clone);
    }
   }
}

