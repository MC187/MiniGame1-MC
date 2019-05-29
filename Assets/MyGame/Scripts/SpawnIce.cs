using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnIce : MonoBehaviour 
{

    public IceDestroy icePrefab;     public GameObject flyParent;



    public float iceMinSize = 0.1f;
    public float iceMaxSize = 0.5f;


    private void Update() {    //  SpawnIc(); }


    IEnumerator Start()     {         while (true)         {             yield return new WaitForSeconds(2);             SpawnIc();         }      }

    private void SpawnIc()     {
        float flySize = Random.Range(iceMinSize, iceMaxSize);

        IceDestroy flyClone = (IceDestroy)Instantiate(icePrefab, transform.position, transform.rotation);

        float iceSize = 0.195441f;

        flyClone.transform.SetParent(flyParent.transform);

        flyClone.transform.localScale = new Vector3(iceSize, iceSize, 0);

       

        flyClone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-6f, 6f), flyParent.transform.position.y, 5f);

        flyClone.GetComponent<Rigidbody2D>().velocity = new Vector2(UnityEngine.Random.Range(-2, 2), UnityEngine.Random.Range(-10, -1));




    }


}
