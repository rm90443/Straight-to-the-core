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
        
    
    

        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>(); 
        spriteRenderer.gameObject.layer = LayerMask.NameToLayer("Primeiro Plano");




        

    }
    
}