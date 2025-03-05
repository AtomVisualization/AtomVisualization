using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bond_Switcher : MonoBehaviour
{
    public static string Bondd;

    public void switch_Bond()
    {
        Bondd = this.name;
        Debug.Log(Bondd);
    }
}
