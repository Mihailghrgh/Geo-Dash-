using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIScore : MonoBehaviour
{

    private int score;

    private int deathNr = 5;

    public GameObject scoreTextPlayer;

    public GameObject livesTextPlayer;

    public void FixedUpdate()
    {
        Text uiScore = this.scoreTextPlayer.GetComponent<Text>();
        uiScore.text = this.score.ToString();

        Text livesUI = this.livesTextPlayer.GetComponent<Text>();
        livesUI.text = this.deathNr.ToString();

    
    }

    public void Scoring()
    {
        score++;
    }

    public void Hits()
    {
        deathNr--;

        if (deathNr == 0)
        {
            SceneManager.LoadScene("Game Over Scene");
        }
    }
}
