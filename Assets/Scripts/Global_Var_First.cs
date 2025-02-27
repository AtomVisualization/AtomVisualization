using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global_Var_First : MonoBehaviour
{
    public static int elec1 = 0;
    public static string atom = "nill";

    public void increment() 
    {
        elec1++;
    }

    public void decrement() 
    {
        elec1--;
    }
}
