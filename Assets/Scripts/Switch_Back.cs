using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switch_Back : MonoBehaviour
{
    public void Switch_Scene()
    {
        SceneManager.LoadScene("Main_Menu");
    }
}

