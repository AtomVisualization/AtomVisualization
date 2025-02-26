using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

using Oculus.Interaction;
using System.Runtime.CompilerServices;
using Meta.WitAi;



public class Electron_Remover : MonoBehaviour
 {

    private void Start()
    {
        GameObject[] gs = GameObject.FindGameObjectsWithTag("destroy");

        foreach (GameObject g in gs) 
        {
            Debug.Log(g.name);
        }
    }
    }

