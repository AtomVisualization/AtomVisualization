using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Switch : MonoBehaviour
{
    public void Switch_Scene(int scene_ID)
    {
        SceneManager.LoadScene(scene_ID);
    }
}
