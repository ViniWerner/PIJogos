using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Buton : MonoBehaviour {
    public bool click;
    public string nomeCena = "cena";
    public  void onMouseEnter()
    {
        click = true;
    }

    void onMouseExit()
    {
        click = false;
    }

    void Start () {
        click = false;
		
	}
	
	void Update () {
        
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(nomeCena);
            }
        
		
        
	}
}
