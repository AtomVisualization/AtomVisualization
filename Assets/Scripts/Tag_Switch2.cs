using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tag_Switch2 : MonoBehaviour
{
    public static bool checkk2 = false;
    private string bond = "nill";
    private void OnTriggerEnter(Collider other)
    {
        bond = Bond_Switcher.Bondd;

        if (bond == "H2")
        {
            if (other.CompareTag("Hydrogen"))
            {
                checkk2 = true;
                Debug.Log("checkk2 is " + checkk2);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Hydrogen") || other.CompareTag("Electron"))
            checkk2 = false;
        Debug.Log("checkk is " + checkk2);
    }

    public void CheckFalse()
    {
        checkk2 = false;
    }
}


