using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Colletable : MonoBehaviour 
{
    private int score = 0;     public TextMeshProUGUI pointsScore;


    private void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log("Triggerevent" + collision.gameObject.name);          if (collision.gameObject.name == "waffel")
        {
            Debug.Log(score);             score = score + 5;             Debug.Log("score" + score);             pointsScore.text = score.ToString();

        }
        else if (collision.gameObject.name == "EndLine")         {             score -= 1;             Debug.Log("score" + score);             pointsScore.text = score.ToString();         } 
    }

    private void OnCollisionEnter2D(Collision2D collision)     {         Debug.Log("CollisionEvent");      }

}
