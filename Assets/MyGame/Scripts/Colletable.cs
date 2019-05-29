using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Colletable : MonoBehaviour 
{
   // private int score = 0;     public TextMeshProUGUI pointsScore;

    public MyScore score;





    private void OnTriggerEnter2D(Collider2D collision)
    {



        Debug.Log("bin auf" + gameObject.name);

        Debug.Log("Triggerevent" + collision.gameObject.name);          if (collision.gameObject.name == "waffel")
        {
            Debug.Log(score);
            // score = score + 5;
            score.score += 10;             Debug.Log("score" + score);             //pointsScore.text = score.ToString();

           // pointsScore.text = score.score.ToString();

        }
        else if (collision.gameObject.name == "EndLine")         {             score.score -= 5;             Debug.Log("score" + score);            // pointsScore.text = score.score.ToString();         } 
    }

    private void OnCollisionEnter2D(Collision2D collision)     {         Debug.Log("CollisionEvent");      }

    private void Update()
    {
        pointsScore.text = score.score.ToString();
    }





}
