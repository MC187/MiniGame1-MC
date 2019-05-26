using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceDestroy : MonoBehaviour {


    private void OnTriggerEnter2D(Collider2D collision)     {         if (collision.gameObject.name == "EndLine")             Destroy(gameObject);     } 


}
