using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColisaoFerramenta : MonoBehaviour
{
    private Rigidbody2D rb;
   // public Text textoPontos;
   // public Text textoFinal;
    private int pontos = -1;

    void Start()
    {
       
        //rb = GetComponent<Rigidbody2D>();
       // textoFinal.text = "";
       // textoFinal.text = textoPontos.text + pontos.ToString();
               
    } 

    void OnTriggerEnter2D(Collider2D collider)
    {
        
        if (collider.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            ScoreLife.score += pontos;
            //pontos = pontos + 1;
            //textoPontos.text = "Score: " + pontos.ToString();

        }




    }

    void Update()
    {
    }
    }



