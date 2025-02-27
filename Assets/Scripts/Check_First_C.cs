using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check_First_C : MonoBehaviour
{
    public int elec;
    public void check() 
    {
        elec = Global_Var_First.elec1;
                if (elec == 2) 
        {
            Debug.Log(elec);
        }
        else 
        {
            Debug.Log("Fail");
        }
    }
}
