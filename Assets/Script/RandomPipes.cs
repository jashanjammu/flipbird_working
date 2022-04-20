using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPipes : MonoBehaviour
{
    public GameObject mupltiPipe;
    // public GameObject downPipe;
    float minValue = 10f;
    float maxValue = 10.5f;
    
     
    // Start is called before the first frame update
    void Start()
    {
       
     
        StartCoroutine(pipeClone1());
       
    }


    IEnumerator pipeClone1()
    {
        //yield return new WaitForSeconds(3f);
        while (true)
        {

           yield return new WaitForSeconds(2f);

            Vector2 temp = transform.position;
            temp.x = 11.66f;

            //   Instantiate(upPipe, new Vector3(temp.x, upPipe.transform.position.y + Random.Range(-0.10f,0.15f), 0), Quaternion.identity);
            Instantiate(mupltiPipe, new Vector3(temp.x, mupltiPipe.transform.position.y + Random.Range(-0.5f, 0.5f), 0), Quaternion.identity);

        }
    }



}
