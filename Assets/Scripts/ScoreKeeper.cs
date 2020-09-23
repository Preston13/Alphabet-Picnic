using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public int score;
    public Text scoreTxt;
    public int highscore;

    public void Start()
    {
        scoreTxt.text = "Score: " + score;
        highscore = PlayerPrefs.GetInt("highscore");
        PlayerPrefs.SetInt("lastScore", 0);
    }

    private void Update()
    {
        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("highscore", score);
        }
    }

    public void UpdateScore()
    {
        score += 10;
        scoreTxt.text = "Score: " + score;
    }

    public void UpdatePenalty()
    {
        score--;
        if (score < 0)
        {
            score = 0;
        }
        scoreTxt.text = "Score: " + score;
    }
}
