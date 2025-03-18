using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tag_Switcher : MonoBehaviour
{
    public static bool checkk = false;
    private string bond = "nill";
    private void OnTriggerEnter(Collider other)
    {
        bond = Bond_Switcher.Bondd;

        if (bond == "H2")
        {
            if (other.CompareTag("Hydrogen"))
            {
                checkk = true;
                Debug.Log("checkk is " + checkk);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Hydrogen") || other.CompareTag("Electron"))
        checkk = false;
        Debug.Log("checkk is " + checkk);
        
    }
    public void CheckFalse()
    {
        checkk = false;
    }
}
