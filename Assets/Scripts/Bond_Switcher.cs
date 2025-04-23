using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bond_Switcher : MonoBehaviour
{
    public static string Bondd;
    public float countt = 0;

    public void switch_Bond()
    {
        // referneces the count variable form the success script
        countt = success.count;

        // sets a global variable to the name of the bond and resets the count 
        Bondd = this.name;
        Debug.Log(Bondd);
        countt = 0;
    }
}
