using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class detection : MonoBehaviour
{

    private string newTag;
    private string oldTag = "H2O";
    private bool debounce = false;

    public static float count2 = 0;
    public static float count3 = 0;
    public static float count4 = 0;
    public static float count5 = 0;
    public static float count6 = 0;
    public static float count7 = 0;
    public static float count8 = 0;
    private static bool debounce2 = false;
    private static bool debounce3 = false;
    private static bool debounce4 = false;
    private static bool debounce5 = false;
    private static bool debounce6 = false;
    private static bool debounce7 = false;
    private bool debounce8 = false;
    private string tag1;





    private void OnTriggerEnter(Collider other)
    {

        GameObject obj = other.GetComponentInParent<Transform>().gameObject;


        if (other.CompareTag("Chlorine"))
        {

            if (debounce8 == true)
            {
                return;
            }
            tag1 = "Chlor_1";

            if (other.CompareTag("Sod_1") || other.CompareTag("Sod_2") || other.CompareTag("Sod_3") || other.CompareTag("Sod_4") || other.CompareTag("Sod_5") || other.CompareTag("Sod_6"))
            {
                return;
            }
            if (debounce2 == false && debounce8 == false)
            {
                count2 = count2 + 1;

            }
            if (debounce8 == false)
            {
                newTag = "Chlor_1";
            }


            this.transform.parent.tag = newTag;
            if (debounce == true)
            {
                return;
            }

            count3 = count3 + 1;

            debounce = true;
            debounce2 = true;
            debounce8 = true;
            other.GetComponent<Chlorine_Success>().stort1(obj, count3, tag1);


            Invoke("ResetCounter", 0.5f);


        }

        if (other.CompareTag("Chlorine_1"))
        {

             if (debounce8 == true)
            {
                return;
            }

            tag1 = "Chlor_2";

            if (other.CompareTag("Sod_1") || other.CompareTag("Sod_2") || other.CompareTag("Sod_3") || other.CompareTag("Sod_4") || other.CompareTag("Sod_5") || other.CompareTag("Sod_6"))
            {
                return;
            }
            if (debounce3 == false && debounce8 == false)
            {
                count2 = count2 + 1;


            }

            if (debounce8 == false)
            {
                newTag = "Chlor_2";
            }

            this.transform.parent.tag = newTag;
            if (debounce == true)
            {
                return;
            }

            count4 = count4 + 1;

            debounce = true;
            debounce3 = true;
            debounce8 = true;
            other.GetComponent<Chlorine_Success>().stort1(obj, count4, tag1);


            Invoke("ResetCounter", 0.5f);


        }

        if (other.CompareTag("Chlorine_2"))
        {

             if (debounce8 == true)
            {
                return;
            }
            tag1 = "Chlor_3";

            if (other.CompareTag("Sod_1") || other.CompareTag("Sod_2") || other.CompareTag("Sod_3") || other.CompareTag("Sod_4") || other.CompareTag("Sod_5") || other.CompareTag("Sod_6"))
            {
                return;
            }
            if (debounce4 == false && debounce8 == false)
            {
                count2 = count2 + 1;


            }

            if (debounce8 == false)
            {
                newTag = "Chlor_3";
            }

            this.transform.parent.tag = newTag;
            if (debounce == true)
            {
                return;
            }

            count5 = count5 + 1;

            debounce = true;
            debounce4 = true;
            debounce8 = true;
            other.GetComponent<Chlorine_Success>().stort1(obj, count5, tag1);


            Invoke("ResetCounter", 0.5f);

        }

        if (other.CompareTag("Chlorine_3"))
        {

             if (debounce8 == true)
            {
                return;
            }

            tag1 = "Chlor_4";

            if (other.CompareTag("Sod_1") || other.CompareTag("Sod_2") || other.CompareTag("Sod_3") || other.CompareTag("Sod_4") || other.CompareTag("Sod_5") || other.CompareTag("Sod_6"))
            {
                return;
            }
            if (debounce5 == false && debounce8 == false)
            {
                count2 = count2 + 1;


            }

            if (debounce8 == false)
            {
                newTag = "Chlor_4";
            }
            this.transform.parent.tag = newTag;
            if (debounce == true)
            {
                return;
            }

            count6 = count6 + 1;

            debounce = true;
            debounce5 = true;
            debounce8 = true;
            other.GetComponent<Chlorine_Success>().stort1(obj, count6, tag1);


            Invoke("ResetCounter", 0.5f);

        }

        if (other.CompareTag("Chlorine_4"))
        {

             if (debounce8 == true)
            {
                return;
            }

            tag1 = "Chlor_5";

            if (other.CompareTag("Sod_1") || other.CompareTag("Sod_2") || other.CompareTag("Sod_3") || other.CompareTag("Sod_4") || other.CompareTag("Sod_5") || other.CompareTag("Sod_6"))
            {
                return;
            }
            if (debounce6 == false && debounce8 == false)
            {
                count2 = count2 + 1;


            }

            if (debounce8 == false)
            {
                newTag = "Chlor_5";
            }
            

            this.transform.parent.tag = newTag;
            if (debounce == true)
            {
                return;
            }

            count7 = count7 + 1;

            debounce = true;
            debounce6 = true;
            debounce8 = true;
            other.GetComponent<Chlorine_Success>().stort1(obj, count7, tag1);


            Invoke("ResetCounter", 0.5f);
        }

        if (other.CompareTag("Chlorine_5"))
        {

             if (debounce8 == true)
            {
                return;
            }

            tag1 = "Chlor_6";

            if (other.CompareTag("Sod_1") || other.CompareTag("Sod_2") || other.CompareTag("Sod_3") || other.CompareTag("Sod_4") || other.CompareTag("Sod_5") || other.CompareTag("Sod_6"))
            {
                return;
            }
            if (debounce7 == false && debounce8 == false)
            {
                count2 = count2 + 1;


            }

            if (debounce8 == false)
            {
                newTag = "Chlor_6";
            }

            this.transform.parent.tag = newTag;
            if (debounce == true)
            {
                return;
            }

            count8 = count8 + 1;

            debounce = true;
            debounce7 = true;
            debounce8 = true;
            other.GetComponent<Chlorine_Success>().stort1(obj, count8, tag1);


            Invoke("ResetCounter", 0.5f);

        }


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Chlorine"))
        {
            count3 = count3 - 1;

            if (count3 < 0)
            {
                count3 = 0;
            }

            debounce8 = false;

        }


        if (other.CompareTag("Chlorine_1"))
        {
            count4 = count4 - 1;

            if (count4 < 0)
            {
                count4 = 0;
            }

            debounce8 = false;
        }

        if (other.CompareTag("Chlorine_2"))
        {
            count5 = count5 - 1;

            if (count5 < 0)
            {
                count5 = 0;
            }

            debounce8 = false;
        }

        if (other.CompareTag("Chlorine_3"))
        {
            count6 = count6 - 1;

            if (count6 < 0)
            {
                count6 = 0;
            }

            debounce8 = false;
        }

        if (other.CompareTag("Chlorine_4"))
        {
            count7 = count7 - 1;

            if (count7 < 0)
            {
                count7 = 0;
            }

            debounce8 = false;
        }


        if (other.CompareTag("Chlorine_5"))
        {
            count8 = count8 - 1;

            if (count8 < 0)
            {
                count8 = 0;
            }

            debounce8 = false;
        }

    }


    public void ResetCounter()
    {
        debounce = false;
    }
}


