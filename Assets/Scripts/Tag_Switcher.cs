using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tag_Switcher : MonoBehaviour
{
    public static bool checkk = false;
    private string bond = "nill";
  public void Switcher1(Collider other)
    {
        bond = Bond_Switcher.Bondd;

        if (bond == "H2")
        {
            if (other.CompareTag("Hydrogen"))
            {
                checkk = true;
                Debug.Log("checkk is true");
            }
        }
    }

    public void Switcher2()
    {
        checkk = false;
    }
}
