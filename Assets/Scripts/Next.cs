using System.Collections;
using System.Collections.Generic;
using UnityEditor.EditorTools;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Next : MonoBehaviour
{

    public GameObject starttext;
    public GameObject text2;
    private float count = 0;


    public void next(int scene_ID)
    {
        if (count == 0)
        {
            starttext.SetActive(false);
            text2.SetActive(true);
            count = count + 1;
            Debug.Log(count);
            return;
        }

        if (count == 1)
        {
            count = 0;
            SceneManager.LoadScene(scene_ID);
            return;
        }
    }
}
