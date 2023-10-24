using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GerenciadorUI : MonoBehaviour
{

    public Sprite[] Mapa;

    public Image MapaAtual;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
        public void AtualizarMapa(int CasaAtual)
        {

            MapaAtual.sprite = Mapa[CasaAtual];


        }

    
}
