using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class success : MonoBehaviour
{
    private bool check1 = false;
    private bool check2 = false;
    // Update is called once per frame
    void Update()
    {
        check1 = Tag_Switcher.checkk;
        check2 = Tag_Switch2.checkk2;

        if (check1 == true && check2 == true)
        {
            Invoke("confirm", 1);
        }
    }

    void confirm()
    {
        Debug.Log("success!");
    }
}
