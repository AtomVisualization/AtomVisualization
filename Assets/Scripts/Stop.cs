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
        ConstantRotation rotational = GetComponent<ConstantRotation>();

        GameObject[] electrons = GameObject.FindGameObjectsWithTag("new");
        foreach (GameObject electron in electrons)
        {
          if (electron.GetComponent<ConstantRotation>().enabled == true)
            {
                electron.GetComponent<ConstantRotation>().enabled = false;


            }
          else
            {
                electron.GetComponent<ConstantRotation>().enabled = true;
            }
           }
           
    }
}

