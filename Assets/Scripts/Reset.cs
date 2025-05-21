using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public GameObject salt;

    private float count1;
    private float count2;

    public void res()
    {

        count1 = detection.count;
        count2 = Detection2.count;
        GameObject[] salts = GameObject.FindGameObjectsWithTag("salt");

        foreach (GameObject salt in salts)
        {
            Destroy(salt);
        }
   
        Instantiate(salt);
    }
}
