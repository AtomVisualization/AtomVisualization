using Meta.XR.Acoustics;
using Oculus.Interaction.Samples;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Stop : MonoBehaviour
{
    private bool IsActive = false;
    // Start is called before the first frame update
public void Halt()
    {

        GameObject[] electrons = GameObject.FindGameObjectsWithTag("new");
        foreach (GameObject electron in electrons)
        {
            electron.GetComponent<ConstantRotation>().enabled = false;
        }
    }
}
