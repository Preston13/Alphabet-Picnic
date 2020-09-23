using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowLastScore : MonoBehaviour
{
    public Text lastScoreTxt;
    // Start is called before the first frame update
    void Start()
    {
        lastScoreTxt.text = "SCORE: " + PlayerPrefs.GetInt("lastScore").ToString();
    }
}
