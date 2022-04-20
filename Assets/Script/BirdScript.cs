using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
  
    float jump = 2f;
    Rigidbody2D myBody;
    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        birdJump();
    }
    void birdJump()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            myBody.velocity = new Vector2(0f, jump);
        
        }
    }

   

  
}
