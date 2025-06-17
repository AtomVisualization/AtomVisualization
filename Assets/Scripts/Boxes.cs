using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class Boxes : MonoBehaviour
{
    // all the boxes and a list of things to deactivate
    public string bond;
    public GameObject box1;
    public GameObject box2;
    public GameObject box3;
    public GameObject box4;
    public GameObject box5;
    public GameObject[] deactivate;

    public void boxes_appear()
    {
        // grabs the current bond that is selected
        bond = Bond_Switcher.Bondd;

        // deletes all items in deactivate (other boxes)
      foreach (GameObject obj in deactivate)
        {
            obj.SetActive(false);
        }

      //activates boxes based on the current bond

        if (bond == "NaCl")
        {
          
                box1.SetActive(true);
                box2.SetActive(true);
        }
        else if (bond == "H2")
        {
            
                box1.SetActive(true);
                box2.SetActive(true);


        }

        else if (bond == "CH4")
        {
            
                box1.SetActive(true);
                box2.SetActive(true);
                box3.SetActive(true);
                box4.SetActive(true);
                box5.SetActive(true);
        }
        else if (bond == "H2O")
        {
                box1.SetActive(true);
                box2.SetActive(true);
                box3.SetActive(true);
        }
    }
    
}
