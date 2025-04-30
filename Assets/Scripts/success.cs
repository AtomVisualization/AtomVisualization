using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Net.Security;
using UnityEngine;

public class success : MonoBehaviour
{
    private bool check1 = false;
    private bool check2 = false;
    private bool check3 = false;
    private bool check4 = false;
    private bool check5 = false;
    private bool checkCL = false;
    private bool checkH1 = false;
    private bool checkH2 = false;
    private string bond = "nill";
    public static float count = 0;
    public GameObject H2_Anim;
    public GameObject CH4_Anim;
    public GameObject NaCl_Anim;
    public GameObject H2O_Anim;
    public GameObject Success_H2;
    public GameObject Success_CH4;
    public GameObject Success_NaCl;
    public GameObject Success_H2O;

    // Update is called once per frame
    void FixedUpdate()
    {
        Invoke("confirm2", 1);
    }


    void confirm2()
    {
        check1 = Tag_Switcher.checkk;
        check2 = Tag_Switch2.checkk2;
        check3 = Tag_Switch3.checkk3;
        check4 = Tag_Switch4.checkk4;
        check5 = Tag_Switch5.checkk5;
        checkCL = Tag_SwitcherCL.checkkCL;
        checkH1 = Tag_SwitchH1.checkkH1;
        checkH2 = Tag_SwitchH2.checkkH2;
        bond = Bond_Switcher.Bondd;

        if (bond == "H2")
        {
            if (count >= 1)
            {
                return;
            }
            else if (check1 == true && check2 == true)
            {
                count = count + 1;
                Invoke("confirm", 1);
                check1 = false;
                check2 = false;
            }
        }

        else if (bond == "CH4")
        {
            if (count >= 1)
            {
                return;
            }
            else if (check1 == true && check2 == true && check3 == true && check4 == true && check5 == true)
            {
                count = count + 1;
                Invoke("confirm", 1);
                check1 = false;
                check2 = false;
                check3 = false;
                check4 = false;
                check5 = false;
            }
        }
        else if (bond == "NaCl")
        {
            if (count >= 1)
            {
                return;
            }
            else if (check1 == true && checkCL == true)
            {
                count = count + 1;
                Invoke("confirm", 1);
                check1 = false;
                checkCL = false;
            }
        }

        else if (bond == "H2O")
        {
            if (count >= 1)
            {
                return;
            }
            else if (check2 == true && checkH1 == true && checkH2 == true)
            {
                count = count + 1;
                Invoke("confirm", 1);
                check2 = false;
                checkH1 = false;
                checkH2 = false;
            }
        }
    }

    void confirm()
    {
        bond = Bond_Switcher.Bondd;


        GameObject[] hydrogens = GameObject.FindGameObjectsWithTag("Hydrogen");
        GameObject[] carbons = GameObject.FindGameObjectsWithTag("Carbon");
        GameObject[] sodiums = GameObject.FindGameObjectsWithTag("Sodium");
        GameObject[] chlorines  = GameObject.FindGameObjectsWithTag("Chlorine");
        GameObject[] oxygens = GameObject.FindGameObjectsWithTag("Oxygen");
        GameObject[] boxes = GameObject.FindGameObjectsWithTag("boxes");
        if (bond == "H2")
        {
            foreach (GameObject hydrogen in hydrogens)
            {
                Destroy(hydrogen);
            }


            foreach (GameObject box in boxes)
            {
                box.SetActive(false);

            }

            Instantiate(H2_Anim);
        }
        else if (bond == "CH4")
        {
            foreach (GameObject carbon in carbons)
            {
                Destroy(carbon);
            }

            foreach (GameObject hydrogen in hydrogens)
            {
                Destroy(hydrogen);
            }


            foreach (GameObject box in boxes)
            {
                box.SetActive(false);

            }

            Instantiate(CH4_Anim);
            Success_NaCl.SetActive(true);
            Invoke("deactivate", 3);
        }

        else if (bond == "NaCl")
        {
            foreach (GameObject sodium in sodiums)
            {
                Destroy(sodium);
            }

            foreach (GameObject chlorine in chlorines)
            {
                Destroy(chlorine);
            }

            foreach (GameObject box in boxes)
            {
                box.SetActive(false);

            }

            Instantiate(NaCl_Anim);
        }

    else if (bond == "H2O")
        {
            foreach (GameObject oxygen in oxygens)
            {
                Destroy(oxygen);
            }

            foreach (GameObject hydrogen in hydrogens)
            {
                Destroy(hydrogen);
            }

            foreach (GameObject box in boxes)
            {
                box.SetActive(false);

            }

            Instantiate(H2O_Anim);

        }

    }

    public void Reset_Count()
    {
        count = 0;

        GameObject[] bonds = GameObject.FindGameObjectsWithTag("bond");

        foreach (GameObject bond in bonds)
        {
            Destroy(bond);
        }
    }

    void deactivate()
    {
        Success_H2.SetActive(false);
        Success_CH4.SetActive(false);
        Success_NaCl.SetActive(false);
        Success_H2O.SetActive(false);
    }
}
