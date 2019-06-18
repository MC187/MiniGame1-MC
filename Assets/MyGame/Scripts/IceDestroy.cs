using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IceDestroy : MonoBehaviour 
{
    private const string TagEndline = "EndLine";

    private void OnTriggerEnter2D(Collider2D collision)     {         if (collision.gameObject.name == TagEndline)             Destroy(gameObject);

        else
        {
            SceneManager.LoadScene("Scene3");
        }

        if (collision.gameObject.name == "waffel")
            Destroy(gameObject);     } 


}
