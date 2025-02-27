using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using JetBrains.Annotations;
using UnityEngine;

public class Atom_Switch : MonoBehaviour
{

    public string atomm = "nill";
    public string namee = "nill";
   public void Switch() 
   {
    atomm = Global_Var_First.atom;
    atomm = this.name;
    Debug.Log(atomm);
   }
}
