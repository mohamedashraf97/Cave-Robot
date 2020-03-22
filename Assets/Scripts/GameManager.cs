using UnityEngine;
using System.Collections;
 
public class GameManager : MonoBehaviour
{
     
     private float timeBtwSpawns;
     public float startTimeBtwSpawns;
     public float timeDecrease;
     public float minTime;
     private float timeBtwHeals;
     public float startTimeBtwHeals;
     public float timeDecreaseHeals;
     public float minTimeHeal;
     public GameObject Enemy;
     public GameObject Heal;
     public Player player; 

     private void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
        timeBtwHeals = startTimeBtwHeals;
    }

 
        void Update ()
    {
        
        Vector2 pos = Camera.main.ViewportToWorldPoint(new Vector2(1, Random.Range(0.1f, 0.8f)));
        Vector2 posHeal = Camera.main.ViewportToWorldPoint(new Vector2(1, Random.Range(0.1f, 0.8f)));

        
        if (timeBtwSpawns <= 0 && player.dead == false )
        {
            
            GameObject Temporary_Enemy_Handler;
            Temporary_Enemy_Handler = Instantiate(Enemy,pos, Quaternion.identity) as GameObject;
            Rigidbody2D Temporary_RigidBody;
            Temporary_RigidBody = Temporary_Enemy_Handler.GetComponent<Rigidbody2D>();
            Destroy(Temporary_Enemy_Handler, 14.0f);
            
            timeBtwSpawns = startTimeBtwSpawns;
            if (startTimeBtwSpawns > minTime) {
                startTimeBtwSpawns -= timeDecrease;
            }
            
        }
        else {
               
               timeBtwSpawns -= Time.deltaTime;

            }
        if (timeBtwHeals <= 0  && player.dead == false )
        {
            
            GameObject Temporary_Heal_Handler;
            Temporary_Heal_Handler = Instantiate(Heal,posHeal, Quaternion.identity) as GameObject;
            Rigidbody2D Temporary_RigidBody;
            Temporary_RigidBody = Temporary_Heal_Handler.GetComponent<Rigidbody2D>();
            Destroy(Temporary_Heal_Handler, 14.0f);
             timeBtwHeals = startTimeBtwHeals;
            if (startTimeBtwHeals > minTimeHeal) {
                startTimeBtwHeals -= timeDecreaseHeals;
            }
        }
         else {
               
               timeBtwHeals -= Time.deltaTime;

            }




    }
}