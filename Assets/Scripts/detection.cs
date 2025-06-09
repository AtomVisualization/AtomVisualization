using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//******************************************


#if UNITY_EDITOR

using UnityEditorInternal;

//*****************************************


public class detection : MonoBehaviour
{

    public float count = 0;
    private string newTag;
    private string oldTag = "H2O";
    private bool debounce = false;

    public static float count2 = 0;
    private static float count3 = 0;
    private static float count4 = 0;
    private static float count5= 0;
    private static float count6 = 0;
    private static float count7 = 0;
    private static float count8 = 0;
    private static bool debounce2 = false;
     private static bool debounce3 = false;
      private static bool debounce4 = false;
       private static bool debounce5 = false;
        private static bool debounce6 = false;
         private static bool debounce7 = false;




    private void OnTriggerEnter(Collider other)
    {

        GameObject obj = other.GetComponentInParent<Transform>().gameObject;

        if (other.CompareTag("Chlorine"))
        {
            if (debounce2 == false)
            {
                newTag = "Chlor_" + count2;
            Create();
            count2 = count2 + 1;
            }
            
            this.transform.parent.tag = newTag;
            if (debounce == true)
            {
                return;
            }

            count3 = count3 + 1;

            debounce = true;
            debounce2 = true;
            other.GetComponent<Chlorine_Success>().stort1(obj, count3);
            

            Invoke("ResetCounter", 0.5f);

        }

        if (other.CompareTag("Chlorine_1"))
        {
            //newTag = "Chlor_" + count2;
            //Create();
            //count2 = count2 + 1;
            this.transform.parent.tag = newTag;
            if (debounce == true)
            {
                return;
            }




            count4 = count4 + 1;

            debounce = true;
            other.GetComponent<Chlorine_Success>().stort1(obj, count);

            Invoke("ResetCounter", 0.5f);
            count4 = count4 + 1;
        }

        if (other.CompareTag("Chlorine_2"))
        {
           // newTag = "Chlor_" + count2;
            //Create();
            //count2 = count2 + 1;
            this.transform.parent.tag = newTag;
            if (debounce == true)
            {
                return;
            }

            count5 = count5 + 1;

            debounce = true;
            other.GetComponent<Chlorine_Success>().stort1(obj, count5);

            Invoke("ResetCounter", 0.5f);

        }

        if (other.CompareTag("Chlorine_3"))
        {
           // newTag = "Chlor_" + count2;
           // Create();
            //count2 = count2 + 1;
            this.transform.parent.tag = newTag;
            if (debounce == true)
            {
                return;
            }


            count6 = count6 + 1;

            debounce = true;
            other.GetComponent<Chlorine_Success>().stort1(obj, count6);

            Invoke("ResetCounter", 0.5f);

        }

        if (other.CompareTag("Chlorine_4"))
        {
            //newTag = "Chlor_" + count2;
           // Create();
           // count2 = count2 + 1;
            this.transform.parent.tag = newTag;
            if (debounce == true)
            {
                return;
            }

            count7 = count7 + 1;

            Debug.Log(count7);

            debounce = true;

            other.GetComponent<Chlorine_Success>().stort1(obj, count7);

            Invoke("ResetCounter", 0.5f);

        }

        if (other.CompareTag("Chlorine_5"))
        {
           // newTag = "Chlor_" + count2;
           // Create();
           // count2 = count2 + 1;
            this.transform.parent.tag = newTag;
            if (debounce == true)
            {
                return;
            }




            count8 = count8 + 1;

            debounce = true;
            other.GetComponent<Chlorine_Success>().stort1(obj, count8);

            Invoke("ResetCounter", 0.5f);

        }


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Chlorine"))
        {

            //count = count - 1;
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

        Add(tags, "Chlor_" + count2);


    }

    public void Des()
    {
        List<string> tags = new List<string>(InternalEditorUtility.tags);

        Remove(tags, "Chlor" + count2);
    }


}


#endif