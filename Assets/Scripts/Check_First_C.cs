using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction.Locomotion;
using Unity.VisualScripting;
using UnityEngine;

public class Check_First_C : MonoBehaviour
{
    // variables
    public int elecc;
    public int elecc2;

    public int elecc3;
    public string namee = "nill";

    public GameObject success;

    public GameObject ring1;
    public GameObject ring2;
    private int count = 0;
    private int count2 = 0;

    public GameObject fail;
    public void Check()
    {
        // grabs the global variables from the script and grabs the current atom selected
        elecc = Global_Var_First.elec1;

        elecc2 = Global_Var_First.elec2;

        elecc3 = Global_Var_First.elec3;

        namee = Atom_Switch.atomm;


        // checks the atom then checks how many electrons are in each box for electron sim and then activates the success or fail text depending on if you are correct or not then deactivates the text after 3 seconds

        if (namee == "Carbon")
        {

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

                    success.SetActive(true);

                    Invoke("Deactivate_S", 3);

                }

                else
                {
                    fail.SetActive(true);
                    Invoke("Deactivate_F", 3);
                }
            }
            else
            {
                fail.SetActive(true);
                Invoke("Deactivate_F", 3);
            }

            count = 0;
        }



        else if (namee == "Hydrogen")
        {
            if (elecc == 1)
            {
                success.SetActive(true);

                Invoke("Deactivate_S", 3);

            }

            else
            {
                fail.SetActive(true);
                Invoke("Deactivate_F", 3);
            }
        }


        else if (namee == "Nitrogen")
        {
            if (elecc == 2)
            {
                if (count == 0)
                {
                    ring1.SetActive(true);
                    count = count + 1;
                    return;
                }
                if (elecc2 == 5)
                {
                    success.SetActive(true);

                    Invoke("Deactivate_S", 3);

                }

                else
                {
                    fail.SetActive(true);
                    Invoke("Deactivate_F", 3);
                }
            }
            else
            {
                fail.SetActive(true);
                Invoke("Deactivate_F", 3);
            }

            count = 0;
        }

        else if (namee == "Oxygen")
        {
            if (elecc == 2)
            {
                if (count == 0)
                {
                    ring1.SetActive(true);
                    count = count + 1;
                    return;
                }

                if (elecc2 == 6)
                {
                    success.SetActive(true);

                    Invoke("Deactivate_S", 3);

                }
                else
                {
                    fail.SetActive(true);
                    Invoke("Deactivate_F", 3);
                }
            }
            else
            {
                fail.SetActive(true);
                Invoke("Deactivate_F", 3);
            }

            count = 0;
        }

        else if (namee == "Phosphorus")
        {
            if (elecc == 2)
            {
                if (count == 0)
                {
                    ring1.SetActive(true);
                    count = count + 1;
                    return;
                }

                if (elecc2 == 8)
                {
                    if (count2 == 0)
                    {
                        ring2.SetActive(true);
                        count2 = count2 + 1;
                        return;
                    }
                    if (elecc3 == 5)
                    {
                        success.SetActive(true);

                        Invoke("Deactivate_S", 3);
                    }

                    else
                    {
                        fail.SetActive(true);
                        Invoke("Deactivate_F", 3);
                    }

                }
                else
                {
                    fail.SetActive(true);
                    Invoke("Deactivate_F", 3);
                }
            }
            else
            {
                fail.SetActive(true);
                Invoke("Deactivate_F", 3);
            }

            count = 0;
            count2 = 0;
        }


        else if (namee == "Sodium")
        {
            if (elecc == 2)
            {
                if (count == 0)
                {
                    ring1.SetActive(true);
                    count = count + 1;
                    return;
                }
                if (elecc2 == 8)
                {
                    if (count2 == 0)
                    {
                        ring2.SetActive(true);
                        count2 = count2 + 1;
                        return;
                    }
                    if (elecc3 == 1)
                    {
                        success.SetActive(true);

                        Invoke("Deactivate_S", 3);
                    }

                    else
                    {
                        fail.SetActive(true);
                        Invoke("Deactivate_F", 3);
                    }

                }
                else
                {
                    fail.SetActive(true);
                    Invoke("Deactivate_F", 3);
                }
            }
            else
            {
                fail.SetActive(true);
                Invoke("Deactivate_F", 3);
            }

            count = 0;
            count2 = 0;
        }



        else if (namee == "Chlorine")
        {
            if (elecc == 2)
            {
                if (count == 0)
                {
                    ring1.SetActive(true);
                    count = count + 1;
                    return;
                }
                if (elecc2 == 8)
                {
                    if (count2 == 0)
                    {
                        ring2.SetActive(true);
                        count2 = count2 + 1;
                        return;
                    }
                    if (elecc3 == 7)
                    {
                        success.SetActive(true);

                        Invoke("Deactivate_S", 3);
                    }

                    else
                    {
                        fail.SetActive(true);
                        Invoke("Deactivate_F", 3);
                    }

                }
                else
                {
                    fail.SetActive(true);
                    Invoke("Deactivate_F", 3);
                }
            }
            else
            {
                fail.SetActive(true);
                Invoke("Deactivate_F", 3);
            }
            count = 0;
            count2 = 0;
        }
    }
    // the deactivate methods for the success and fail text
    void Deactivate_S() {
        success.SetActive(false);
    }

    void Deactivate_F() {
        fail.SetActive(false);
    }
 
}

