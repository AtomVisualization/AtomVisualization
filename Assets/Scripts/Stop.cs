using Meta.XR.Acoustics;
using Oculus.Interaction.Samples;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Stop : MonoBehaviour
{
    private bool isActive = true;
public void Halt()
    {

        GameObject[] electrons = GameObject.FindGameObjectsWithTag("new");
        if (isActive == true)
        foreach (GameObject electron in electrons)
        {
           foreach (var comp in electron.GetComponents<ConstantRotation>()) 
           {
            if (comp.isActiveAndEnabled) 
            {
               
            }
                }
           }
           
    }
}

