using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHighScore : MonoBehaviour
{
    public Text highScoreTxt;

    // Start is called before the first frame update
    void Start()
    {
        highScoreTxt.text = "High Score: " + PlayerPrefs.GetInt("highscore", 0).ToString();
    }
}
