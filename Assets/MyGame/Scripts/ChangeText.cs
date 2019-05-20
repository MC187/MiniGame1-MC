using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ChangeText : MonoBehaviour {


    public Text myText;
    public TextMeshProUGUI myTMPText;
    private int countPresses = 0;

    public TestingRandom myScript;


    private System.Random rnd = new System.Random();
    private System.Random seedRnd = new System.Random(123);






    // Use this for initialization
    void Start () {

        myText.text = "Halooooooooooo";

        myTMPText.text = "Nochmaaaalll jalllloooo";

        Debug.Log("+++++++++"+ rnd.Next(0, 5));
        Debug.Log("seed" + seedRnd.Next(0, 5));
        Debug.Log("Random UE" + UnityEngine.Random.Range(0,1));



    }
	



    public void addPress()
    {
        countPresses++;
        // countPresses = countPresses + 1 , ist das selbe wie oben 
        //countPresses += 1; same here

        Debug.Log("counts: " + countPresses);
        myText.text = countPresses.ToString();

        Debug.Log("seed" + seedRnd.Next(0, 5));

        myScript.ChangeRandomCube();


    }




    // Update is called once per frame
    void Update () {
		
	}
}
