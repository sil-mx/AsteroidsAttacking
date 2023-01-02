using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverScreen : MonoBehaviour
{
    public int score;
    public TMP_Text endScoreText;
    public int endScore;


    private void Start()
    {
        endScore = PlayerPrefs.GetInt("endscore");
        endScoreText.text = "Your Score: " + endScore;
    }

    public void Setup(int points)
    {
        endScore = points;
        endScoreText.text = "Your Score: " + score;
        if (endScore >= score)
            PlayerPrefs.SetInt("endsore", score);
    }
}
