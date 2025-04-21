using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tag_SwitcherCL : MonoBehaviour
{
    public static bool checkkCL = false;
    private string bond = "nill";
    private void OnTriggerEnter(Collider other)
    {
        bond = Bond_Switcher.Bondd;

        if (bond == "NaCl")
        {
            if (other.CompareTag("Chlorine"))
            {
                checkkCL = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Hydrogen") || other.CompareTag("Electron") || other.CompareTag("Carbon") || other.CompareTag("Chlorine") || other.CompareTag("Sodium") || other.CompareTag("Oxygen"))
            checkkCL = false;
     

    }
    public void CheckFalse()
    {
        checkkCL = false;
    }
}
