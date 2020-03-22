using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Lives : MonoBehaviour
{

public Text life;
public Player player;


    void Start()
    {
        life = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
     
      int lives = player.lives;
     life.text = "Lives: " + lives.ToString();
       
        
    
    }
}
