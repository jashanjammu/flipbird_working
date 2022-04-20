using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderColider : MonoBehaviour
{
    // Start is called before the first frame update

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "clonePipe")
        {
            print(collision.gameObject.name);
            // collision.gameObject.SetActive(false);
            Destroy(collision.gameObject);
            
        }
    }
}
