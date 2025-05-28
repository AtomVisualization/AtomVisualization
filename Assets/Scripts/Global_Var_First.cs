using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global_Var_First : MonoBehaviour
{
    public static int elec1 = 0;
    public static int elec2 = 0;
    public static int elec3 = 0;
 
   

    public void increment() 
    {
        elec1++;
    }

    public void decrement() 
    {
        elec1--;
    }

    public void increment2() 
    {
        elec2++;
    }

    public void decrement2() 
    {
        elec2--;
    }

    public void increment3() 
    {
        elec3++;
    }

    public void decrement3() 
    {
        elec3--;
    }
}
