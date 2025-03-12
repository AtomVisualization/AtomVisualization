using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction.Locomotion;
using Unity.VisualScripting;
using UnityEngine;

public class Check_First_C : MonoBehaviour
{
    public int elecc;
    public int elecc2;

    public int elecc3;
    public string namee = "nill";

    public GameObject success;

    public GameObject fail;
    public void Check() 
    {
        elecc = Global_Var_First.elec1;

        elecc2 = Global_Var_First.elec2;

        elecc3 = Global_Var_First.elec3;

        namee = Atom_Switch.atomm;




                if (namee == "Carbon") 
                {
                    if (elecc == 2) 
                    {
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
            
        
        }



        else if (namee == "Hydrogen") 
        {
            if (elecc == 1) {
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
        }

        else if (namee == "Oxygen") 
        {
             if (elecc == 2) 
            {
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
        }

        else if (namee == "Phosphorus") 
        {
             if (elecc == 2) 
            {
                if (elecc2 == 8) 
                {
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
        }

        else if (name == "Sodium")
        {
            if (elecc == 2)
            {
                if (elecc2 == 8)
                {
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
        }

        else if (name == "Chlorine")
        {
            if (elecc == 2)
            {
                if (elecc2 == 8)
                {
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
        }

    }

    void Deactivate_S() {
        success.SetActive(false);
    }

    void Deactivate_F() {
        fail.SetActive(false);
    }
 
}

