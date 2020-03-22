using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
     public float speed ;
   
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);     

        }
    }
}
