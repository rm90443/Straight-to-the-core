using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    

    public float StartTheBattle;

    void Start()
    {
    
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D (Collider2D other) 
    {

     if (other.tag == "Player")
        {

            Player player = other.GetComponent<Player>();

            if (player != null)
            {
              
                player.LigarBatalhaDeTurno();

            }


          


        }

    }
    
}