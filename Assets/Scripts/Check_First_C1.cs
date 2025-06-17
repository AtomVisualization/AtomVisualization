using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction.Locomotion;
using Unity.VisualScripting;
using UnityEngine;

public class Check_First_C1 : MonoBehaviour
{
    // variables
    public int elecc;
    public int elecc2;

    public int elecc3;
    public string namee = "nill";


    public GameObject ring1;
    public GameObject ring2;
    private int count = 0;
    private int count2 = 0;

    public GameObject next;


    public void Check()
    {
        // grabs the global variables from the script and grabs the current atom selected
        elecc = Global_Var_First.elec1;

        elecc2 = Global_Var_First.elec2;

        elecc3 = Global_Var_First.elec3;

        namee = Atom_Switch.atomm;


        // checks the atom then checks how many electrons are in each box for electron sim and then activates the success or fail text depending on if you are correct or not then deactivates the text after 3 seconds



        if (elecc == 2)
        {
            if (count == 0)
            {
                ring1.SetActive(true);
                count = count + 1;
                return;
            }

            if (elecc2 == 4)
            {

                next.SetActive(true);

            }

        }

        count = 0;
        
    }
    





    }

