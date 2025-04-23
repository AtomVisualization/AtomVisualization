using Meta.XR.Acoustics;
using Oculus.Interaction.Samples;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Stop : MonoBehaviour
{
    // Start is called before the first frame update
public void Halt()
    {

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
