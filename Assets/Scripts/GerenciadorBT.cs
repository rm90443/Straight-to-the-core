using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciadorBT : MonoBehaviour
{

    public GameObject player;

    public GameObject Inimigo;

    void Start()
    {

        Instantiate(player, Vector3.zero, Quaternion.identity);

        Instantiate(Inimigo, Vector3.zero, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MudarCena(string BatalhaDeTurno)
    {

        Player player = other.GetComponent<Player>();

        if (BatalhaDeTurno == true) 
        {
            SceneManager.LoadScene(BatalhaDeTurno);

        }
    }
}
