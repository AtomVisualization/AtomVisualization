using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tag_SwitchH1 : MonoBehaviour
{
    public static bool checkkH1 = false;
    private string bond = "nill";
    private void OnTriggerEnter(Collider other)
    {
        bond = Bond_Switcher.Bondd;

        if (bond == "H2O")
        {
            if (other.CompareTag("Hydrogen"))
            {
                checkkH1 = true;
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Hydrogen") || other.CompareTag("Electron") || other.CompareTag("Carbon") || other.CompareTag("Chlorine") || other.CompareTag("Sodium") || other.CompareTag("Oxygen"))
            checkkH1 = false;
       
    }

    public void CheckFalse()
    {
        checkkH1 = false;
    }
}