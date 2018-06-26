using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarLevel3 : MonoBehaviour
{
    public string nomeLevel = "TelaAcao3";

    Vector3 touchPosWorld;

    //Change me to change the touch phase used.
    TouchPhase touchPhase = TouchPhase.Ended;

    void Start()
    {

    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            touchPosWorld = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);

            Vector2 touchPosWorld2D = new Vector2(touchPosWorld.x, touchPosWorld.y);

            //We now raycast with this information. If we have hit something we can process it.
            RaycastHit2D hitInformation = Physics2D.Raycast(touchPosWorld2D, Camera.main.transform.forward);

            if (hitInformation.collider != null)
            {
                GameObject touchedObject = hitInformation.transform.gameObject;
                if (touchedObject.tag == "hard")
                {
                    SceneManager.LoadScene(nomeLevel);
                }
               
            }



        }
    }
}