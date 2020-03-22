using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
     private Vector2 targetPos;
     public GameObject effect;
     public float speed;
     public bool dead ;
     public Animator anim ;
     public int lives = 3;

    void Update()
    {
          transform.position = Vector2.MoveTowards(transform.position, targetPos, 100*Time.deltaTime);
       
         if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < 9.2f) {
            
            targetPos = new Vector2(transform.position.x, transform.position.y + speed);
            
            
    } else if(Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > -8.9f)
    {

            targetPos = new Vector2(transform.position.x, transform.position.y -speed);

    }
}
  void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if(lives !=0)
            {
            lives = lives - 1;
            }
            if(lives == 0)
            {
            dead = true; 
            anim.SetBool("dead",true);   
            }       

        }

        else if (collision.gameObject.tag == "Heal")
        {
          lives = lives +1 ;
          Instantiate(effect, transform.position, Quaternion.identity);
            
        }
    }

}
