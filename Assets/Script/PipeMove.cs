using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PipeMove : MonoBehaviour
{

  // [SerializeField] private Text score;
    
    Rigidbody2D myBody;
    private float speed = 1f;
   
      
    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        pipeMove();
    }
    void pipeMove()
    {
         myBody.velocity = new Vector2(-speed,0f);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.tag =="Bird")
           
        {
            GameManager.instance.score();


        }
    }

}
