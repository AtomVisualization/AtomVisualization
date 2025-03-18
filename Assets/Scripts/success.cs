using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Net.Security;
using UnityEngine;

public class success : MonoBehaviour
{
    private bool check1 = false;
    private bool check2 = false;
    public static float count = 0;
    public GameObject H2_Anim;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        Invoke("confirm2", 1);
    }


    void confirm2()
    {
        check1 = Tag_Switcher.checkk;
        check2 = Tag_Switch2.checkk2;

        Debug.Log("check1 is " + check1);
        Debug.Log("check2 is " + check2);

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

    void confirm()
    {
        GameObject[] hydrogens = GameObject.FindGameObjectsWithTag("Hydrogen");
        GameObject[] boxes = GameObject.FindGameObjectsWithTag("boxes");


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

    public void Reset_Count()
    {
        count = 0;

        GameObject[] bonds = GameObject.FindGameObjectsWithTag("bond");

        foreach (GameObject bond in bonds)
        {
            Destroy(bond);
        }
    }
}
