using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//******************************************


#if UNITY_EDITOR

using UnityEditorInternal;

#endif

//*****************************************


public class Detection2 : MonoBehaviour
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




    private void OnTriggerEnter(Collider other)
    {

        GameObject obj = other.GetComponentInParent<Transform>().gameObject;

        if (other.CompareTag("Sodium"))
        {
            if (debounce2 == false)
            {
                count2 = count2 + 1;
                Create();

            }
                if (debounce8 == false)
            {
                newTag = "Sod_" + count2;
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
            other.GetComponent<Sodium_Success>().stort1(obj, count3);


            Invoke("ResetCounter", 0.5f);


        }

        if (other.CompareTag("Sodium_1"))
        {
            if (debounce3 == false)
            {
                count2 = count2 + 1;
                Create();

            }

            newTag = "Sod_" + count2;

            this.transform.parent.tag = newTag;
            if (debounce == true)
            {
                return;
            }

            count4 = count4 + 1;

            debounce = true;
            debounce3 = true;
           other.GetComponent<Sodium_Success>().stort1(obj, count4);


            Invoke("ResetCounter", 0.5f);


        }

        if (other.CompareTag("Sodium_2"))
        {
            if (debounce4 == false)
            {
                count2 = count2 + 1;
                Create();

            }

            newTag = "Sod_" + count2;

            this.transform.parent.tag = newTag;
            if (debounce == true)
            {
                return;
            }

            count5 = count5 + 1;

            debounce = true;
            debounce4 = true;
            other.GetComponent<Sodium_Success>().stort1(obj, count5);


            Invoke("ResetCounter", 0.5f);

        }

        if (other.CompareTag("Sodium_3"))
        {
            if (debounce5 == false)
            {
                count2 = count2 + 1;
                Create();

            }

            newTag = "Sod_" + count2;

            this.transform.parent.tag = newTag;
            if (debounce == true)
            {
                return;
            }

            count6 = count6 + 1;

            debounce = true;
            debounce5 = true;
           other.GetComponent<Sodium_Success>().stort1(obj, count6);


            Invoke("ResetCounter", 0.5f);

        }

        if (other.CompareTag("Sodium_4"))
        {
            if (debounce6 == false)
            {
                count2 = count2 + 1;
                Create();

            }

            newTag = "Sod_" + count2;

            this.transform.parent.tag = newTag;
            if (debounce == true)
            {
                return;
            }

            count7 = count7 + 1;

            debounce = true;
            debounce6 = true;
            other.GetComponent<Sodium_Success>().stort1(obj, count7);


            Invoke("ResetCounter", 0.5f);
        }

        if (other.CompareTag("Sodium_5"))
        {
            if (debounce7 == false)
            {
                count2 = count2 + 1;
                Create();

            }

            newTag = "Sod_" + count2;

            this.transform.parent.tag = newTag;
            if (debounce == true)
            {
                return;
            }

            count8 = count8 + 1;

            debounce = true;
            debounce7 = true;
            other.GetComponent<Sodium_Success>().stort1(obj, count8);


            Invoke("ResetCounter", 0.5f);

        }


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Sodium"))
        {
            count3 = count3 - 1;

            if (count3 < 0)
            {
                count3 = 0;
            }



            if (other.CompareTag("Sodium_1"))
            {
                count4 = count4 - 1;

                if (count4 < 0)
                {
                    count4 = 0;
                }
            }

            if (other.CompareTag("Sodium_2"))
            {
                count5 = count5 - 1;

                if (count5 < 0)
                {
                    count5 = 0;
                }
            }

            if (other.CompareTag("Sodium_3"))
            {
                count6 = count6 - 1;

                if (count6 < 0)
                {
                    count6 = 0;
                }
            }

            if (other.CompareTag("Sodium_4"))
            {
                count7 = count7 - 1;

                if (count7 < 0)
                {
                    count7 = 0;
                }
            }


            if (other.CompareTag("Sodium_5"))
            {
                count8 = count8 - 1;

                if (count8 < 0)
                {
                    count8 = 0;
                }
            }
        }
    }

    public void ResetCounter()
    {
        debounce = false;
    }

    static private void Add(List<string> tags, string tag)
    {

        InternalEditorUtility.AddTag(tag);

        tags.Add(tag);




    }

    static private void Remove(List<string> tags, string tag)
    {
        InternalEditorUtility.RemoveTag(tag);

        tags.Remove(tag);




    }


    public void Create()
    {

        List<string> tags = new List<string>(InternalEditorUtility.tags);

        Add(tags, "Sod_" + count2);


    }

    public void Des()
    {
        List<string> tags = new List<string>(InternalEditorUtility.tags);

        Remove(tags, "Sod_" + count2);
    }


}


