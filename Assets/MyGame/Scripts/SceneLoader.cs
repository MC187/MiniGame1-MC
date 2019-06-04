using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour 
{
    public void LoadScene(string Scene1)
    {
        SceneManager.LoadScene("Scene1");

        // Application.LoadLevel(Scene1);  -> yt tutorial
    }



}
