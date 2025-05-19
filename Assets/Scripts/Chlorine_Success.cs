using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chlorine_Success : MonoBehaviour
{
 private float count;

    public GameObject Chlorine;

   
    private Vector3 pos;
    private Vector3 currentpos1;
    private Vector3 currentpos2;


    // Update is called once per frame
    void FixedUpdate()
    {
        Invoke("check2", 1);
    }

    void check2()
    {
        count = detection.count;

        if (count >= 6)
        {
            StartCoroutine(LerpValue(0, 1));
        }
    }


    IEnumerator LerpValue(float start, float end)
    {

        float elapsedTime1 = 0f;
        float waitTime1 = .5f;
        float elapsedTime2 = 0f;
        float waitTime2 = .5f;
        currentpos1 = Chlorine.transform.position;
        pos = new Vector3(transform.position.x, transform.position.y - .1f, transform.position.z - .2f);
        GameObject[] waters = GameObject.FindGameObjectsWithTag("water");

        while (elapsedTime1 < waitTime1)
        {
            Chlorine.transform.position = Vector3.Lerp(currentpos1, pos, (elapsedTime1 / waitTime1));
            elapsedTime1 += Time.deltaTime;
            Invoke("del2", 1);

            yield return null;
        }
        while (elapsedTime2 < waitTime2)
        {
            foreach (GameObject water in waters)
            {
                currentpos2 = water.transform.position;
                water.transform.position = Vector3.Lerp(currentpos2, pos, (elapsedTime2 / waitTime2));
                elapsedTime2 += Time.deltaTime;

                yield return null;
            }
            Invoke("del1", 1);

        }

    }

    void del1()
    {
        GameObject[] waters = GameObject.FindGameObjectsWithTag("water");
        foreach (GameObject water in waters)
        {
            Destroy(water);
        }

    }

    void del2()
    {
        Destroy(Chlorine);
    }
}

