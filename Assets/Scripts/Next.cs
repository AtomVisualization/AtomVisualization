using System.Collections;
using System.Collections.Generic;
//using UnityEditor.EditorTools;
using UnityEngine;

public class Next : MonoBehaviour
{

    public GameObject starttext;
    public GameObject text2;
    private float count = 0;
    

    public void next()
    {
        if (count == 0)
        {
            starttext.SetActive(false);
            text2.SetActive(true);
        }
    }
}
