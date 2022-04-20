using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PipeTrigger : MonoBehaviour
{
   
//    public SpriteRenderer over;
    // Start is called before the first frame update
    void Start()
    {
         

       // Update is called once per frame
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bird")
        {
            SoundManager.playSound();
            Destroy(collision.gameObject);
            Time.timeScale = 0;
            GameManager.isGameOver = true;
            
        }

    }

}
