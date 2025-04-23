using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using JetBrains.Annotations;
using UnityEngine;

public class Atom_Switch : MonoBehaviour
{
    // global variables
    public static string atomm = "nill";
    public string namee = "nill";
   public void Switch() 
   {
    // Switches the global variable to the name of the atom for reference in other scripts 
    atomm = this.name;
    Debug.Log(atomm + " hi");
   }
}
