using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Reset : MonoBehaviour
{

    public GameObject water;
    public GameObject salt;
    public void res()
    {
        GameObject[] salts = GameObject.FindGameObjectsWithTag("salt");
        GameObject[] waters = GameObject.FindGameObjectsWithTag("H2O");
        GameObject[] waters2 = GameObject.FindGameObjectsWithTag("water");
        GameObject[] waters3 = GameObject.FindGameObjectsWithTag("water3");
        GameObject[] chlor_0 = GameObject.FindGameObjectsWithTag("Chlor_1");
        GameObject[] chlor_1 = GameObject.FindGameObjectsWithTag("Chlor_2");
        GameObject[] chlor_2 = GameObject.FindGameObjectsWithTag("Chlor_3");
        GameObject[] chlor_3 = GameObject.FindGameObjectsWithTag("Chlor_4");
        GameObject[] chlor_4 = GameObject.FindGameObjectsWithTag("Chlor_5");
        GameObject[] chlor_5 = GameObject.FindGameObjectsWithTag("Chlor_6");
        GameObject[] chlor_6 = GameObject.FindGameObjectsWithTag("Chlor_7");
        GameObject[] chlor_7 = GameObject.FindGameObjectsWithTag("Chlor_8");
        GameObject[] sod_0 = GameObject.FindGameObjectsWithTag("Sod_1");
        GameObject[] sod_1 = GameObject.FindGameObjectsWithTag("Sod_2");
        GameObject[] sod_2 = GameObject.FindGameObjectsWithTag("Sod_3");
        GameObject[] sod_3 = GameObject.FindGameObjectsWithTag("Sod_4");
        GameObject[] sod_4 = GameObject.FindGameObjectsWithTag("Sod_5");
        GameObject[] sod_5 = GameObject.FindGameObjectsWithTag("Sod_6");
         GameObject[] sod_6 = GameObject.FindGameObjectsWithTag("Sod_7");
          GameObject[] sod_7 = GameObject.FindGameObjectsWithTag("Sod_8");

        detection.count3 = 0;
        detection.count4 = 0;
        detection.count5 = 0;
        detection.count6 = 0;
        detection.count7 = 0;
        detection.count8 = 0;
        detection.count9 = 0;
        detection.count10 = 0;
        Detection2.count3 = 0;
        Detection2.count4 = 0;
        Detection2.count5 = 0;
        Detection2.count6 = 0;
        Detection2.count7 = 0;
        Detection2.count8 = 0;
        Detection2.count9 = 0;
        Detection2.count10 = 0;



        foreach (GameObject salt in salts)
        {
            Destroy(salt);
        }

        foreach (GameObject water in waters)
        {
            Destroy(water);
        }

        foreach (GameObject water in waters2)
        {
            Destroy(water);
        }

        foreach (GameObject water in waters3)
        {
            Destroy(water);
        }

        foreach (GameObject water in chlor_0)
        {
            Destroy(water);
        }

        foreach (GameObject water in chlor_1)
        {
            Destroy(water);
        }

        foreach (GameObject water in chlor_2)
        {
            Destroy(water);
        }

        foreach (GameObject water in chlor_3)
        {
            Destroy(water);
        }

        foreach (GameObject water in chlor_4)
        {
            Destroy(water);
        }

        foreach (GameObject water in chlor_5)
        {
            Destroy(water);
        }

         foreach (GameObject water in chlor_6)
        {
            Destroy(water);
        }

         foreach (GameObject water in chlor_7)
        {
            Destroy(water);
        }

        foreach (GameObject water in sod_0)
        {
            Destroy(water);
        }
        foreach (GameObject water in sod_1)
        {
            Destroy(water);
        }
        foreach (GameObject water in sod_2)
        {
            Destroy(water);
        }
        foreach (GameObject water in sod_3)
        {
            Destroy(water);
        }
        foreach (GameObject water in sod_4)
        {
            Destroy(water);
        }
        foreach (GameObject water in sod_5)
        {
            Destroy(water);
        }

         foreach (GameObject water in sod_6)
        {
            Destroy(water);
        }

         foreach (GameObject water in sod_7)
        {
            Destroy(water);
        }

        Instantiate(water);
        Instantiate(salt);
    }
}
