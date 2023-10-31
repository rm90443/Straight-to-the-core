using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float Velocidade = 5.0f; 

    public int Casas = 0;

    private int QuantidadedeInimigos = 0;

    public GameObject Inimigo;

    private GerenciadorUI _uiGerenciador;

    public bool BatalhaDeTurno = false;

    // Start is called before the first frame update
    void Start()
    {

        transform.position = new Vector3(-6.96f, -3.6f, 0);

        _uiGerenciador = GameObject.Find("Canvas").GetComponent<GerenciadorUI>();

        if (_uiGerenciador != null)
        {

            _uiGerenciador.AtualizarMapa(Casas);

        }

    }

    // Update is called once per frame
    void Update()
    {
    
    float movimentoHorizontal = Input.GetAxis("Horizontal");
    float movimentoVertical = Input.GetAxis("Vertical");

    Vector3 movimento = new Vector3(movimentoHorizontal, 0, movimentoVertical) * Velocidade * Time.deltaTime;
    transform.Translate(movimento);

    if ( transform.position.x > 11.11f)
        {

      transform.position = new Vector3(-7f, transform.position.y,0);
      
      Casas += 1;

            _uiGerenciador.AtualizarMapa(Casas);

        }

    else if (transform.position.x < -7f)
        {

    transform.position = new Vector3(11.11f, transform.position.y,0);

      Casas -= 1;

            _uiGerenciador.AtualizarMapa(Casas);

        }

        if (Casas == 6 && QuantidadedeInimigos <= 0)
        {

            Debug.Log("Apareceinimigo");

            Instantiate(Inimigo, transform.position + new Vector3(31.27f, 0, 0), Quaternion.identity);
            QuantidadedeInimigos = QuantidadedeInimigos + 1;

        }   

    }

    public void LigarBatalhaDeTurno()
    {

        BatalhaDeTurno = true;
   
    }

}

