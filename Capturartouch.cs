using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Capturartouch : MonoBehaviour
{
    [SerializeField]
    GameObject objectToDestroy;

    Vector3 touchPosWorld;

    //Change me to change the touch phase used.
    TouchPhase touchPhase = TouchPhase.Ended;

    public void Destruir()
    {
        Destroy(gameObject);
    }


	void Start () {
	
	}

	void Update()
	{
		if (Input.touchCount > 0) {
            touchPosWorld = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);

            Vector2 touchPosWorld2D = new Vector2(touchPosWorld.x, touchPosWorld.y);

            //We now raycast with this information. If we have hit something we can process it.
            RaycastHit2D hitInformation = Physics2D.Raycast(touchPosWorld2D, Camera.main.transform.forward);

            if (hitInformation.collider != null)
            {
                    GameObject touchedObject = hitInformation.transform.gameObject;
                    if (touchedObject.tag == "ferramenta" || touchedObject.tag == "fruta")
                        Destroy(touchedObject);
                    //Destruir();
            }
            //if (Input.GetTouch(0).position.x > transform.position.x && Input.GetTouch(0).position.x < transform.position.)
            //transform.Translate (Input.GetTouch (0).deltaPosition * Time.deltaTime * 1f);
            //Destroy(gameObject);
            

		}
	}
}