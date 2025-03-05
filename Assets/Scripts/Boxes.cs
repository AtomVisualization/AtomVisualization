using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Boxes : MonoBehaviour
{
    public string bond;
    public GameObject box1;
    public GameObject box2;
    public GameObject box3;
    public GameObject box4;
    public GameObject box5;
    public GameObject[] deactivate;

    public void boxes_appear()
    {
        bond = Bond_Switcher.Bondd;

      foreach (GameObject obj in deactivate)
        {
            obj.SetActive(false);
        }

        if (bond == "NaCl")
        {
            if (box1.activeSelf != true)
            {
                box1.SetActive(true);
                box2.SetActive(true);
            }
            else
            {
                box1.SetActive(false);
                box2.SetActive(false);
            }
        }
        else if (bond == "H2")
        {
            
                box1.SetActive(true);
                box2.SetActive(true);


        }

        else if (bond == "CH4")
        {
            if (box4.activeSelf != true )
            {
                box1.SetActive(true);
                box2.SetActive(true);
                box3.SetActive(true);
                box4.SetActive(true);
                box5.SetActive(true);
            }
            else
            {
                box1.SetActive(false);
                box2.SetActive(false);
                box3.SetActive(false);
                box4.SetActive(false);
                box5.SetActive(false);
            }
        }
        else if (bond == "H2O")
        {
            box1.SetActive(true);
            box2.SetActive(true);
            box3.SetActive(true);
        }
    }
    
}
