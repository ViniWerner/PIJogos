using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScoreLife : MonoBehaviour
{
    public static int score;        // The player's score.
    public string nomeCena = "cena";

    Text text;                      // Reference to the Text component.


    void Awake()
    {
        // Set up the reference.
        text = GetComponent<Text>();

        // Reset the score.
        score = 5;
    }


    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        text.text = " " + score;
        if(score == 0)
        {
            SceneManager.LoadScene(nomeCena);
        }
    }
}