using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tag_Switch4 : MonoBehaviour
{
    public static bool checkk4 = false;
    private string bond = "nill";
    private void OnTriggerEnter(Collider other)
    {
        bond = Bond_Switcher.Bondd;

        if (bond == "CH4")
        {
            if (other.CompareTag("Hydrogen"))
            {
                checkk4 = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Hydrogen") || other.CompareTag("Electron") || other.CompareTag("Carbon") || other.CompareTag("Chlorine") || other.CompareTag("Sodium") || other.CompareTag("Oxygen"))
            checkk4 = false;

    }

    public void CheckFalse()
    {
        checkk4 = false;
    }
}



