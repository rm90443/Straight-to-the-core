using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float Velocidade = 5.0f; 

    public int Casas = 0;

    public int NúmeroDeCasas = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    float movimentoHorizontal = Input.GetAxis("Horizontal");
    float movimentoVertical = Input.GetAxis("Vertical");

    Vector3 movimento = new Vector3(movimentoHorizontal, 0, movimentoVertical) * Velocidade * Time.deltaTime;
    transform.Translate(movimento);

    if ( transform.position.x > 9.7f){

      transform.position = new Vector3(-8.05f,transform.position.y,0);
      
      Casas += 1;

    }

    else if (transform.position.x < -8.05f){

    transform.position = new Vector3(9.7f,transform.position.y,0);
    
    }
   
   



    
   }

}

