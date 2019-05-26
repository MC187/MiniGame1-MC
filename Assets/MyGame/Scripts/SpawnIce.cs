using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnIce : MonoBehaviour 
{
    
    public IceDestroy berryIce;     public GameObject flyParent;



        private void Update() {    //  SpawnIc(); }


    IEnumerator Start()     {         while (true)         {             yield return new WaitForSeconds(3);             SpawnIc();         }      }

    private void SpawnIc()     {

        IceDestroy flyClone = (IceDestroy)Instantiate(berryIce, transform.position, transform.rotation);

        float flySize = 3;

        flyClone.transform.localScale = new Vector3(flySize, flySize, 0);

        flyClone.transform.SetParent(flyParent.transform);

        flyClone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-6f, 6f), flyParent.transform.position.y, 0f);

        flyClone.GetComponent<Rigidbody2D>().velocity = new Vector2(UnityEngine.Random.Range(-2, 2), UnityEngine.Random.Range(-10, -1));




    }


}
