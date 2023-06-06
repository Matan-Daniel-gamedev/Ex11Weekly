using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    int score = 0;

    public void addScore()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();
    }
}
