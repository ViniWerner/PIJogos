using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsOfColision : MonoBehaviour
{


    public static SoundsOfColision Instance;
    public AudioClip AudioObj;

    public void MakeAudio()
    {
        MakeSound (AudioObj);
    }
    public void MakeSound(AudioClip AudioObj)
    {
        AudioSource.PlayClipAtPoint(AudioObj, transform.position);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.gameObject.tag == "Player")
        {
            MakeSound(AudioObj);
        }

    }

}