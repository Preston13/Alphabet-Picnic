using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Difficulty : MonoBehaviour
{
    public enum difficulty { easy, medium, hard };
    public ToggleGroup toggle;
    public Toggle easyButton;
    public Toggle mediumButton;
    public Toggle hardButton;
    public AudioClip easyVO;
    public AudioClip mediumVO;
    public AudioClip hardVO;

    public difficulty mode;

    private AudioSource audio;

    void Awake()
    {
        audio = GetComponent<AudioSource>();
        toggle = GetComponent<ToggleGroup>();
        int number = PlayerPrefs.GetInt("difficulty");
        mode = (Difficulty.difficulty) number;

        if (mode == (Difficulty.difficulty) 0)
        {
            easyButton.isOn = true;
        }
        else if (mode == (Difficulty.difficulty) 1)
        {
            easyButton.isOn = false;
            mediumButton.isOn = true;
        }
        else
        {
            easyButton.isOn = false;
            hardButton.isOn = true;
        }
    }

    public void LoadDifficulty(string difficult = "EasyButton")
    {
        if (difficult == "EasyButton") 
        {
            audio.clip = easyVO;
            mode = difficulty.easy;
        }
        else if (difficult == "HardButton")
        {
            audio.clip = hardVO;
            mode = difficulty.hard;
        }
        else if (difficult == "MediumButton")
        {
            audio.clip = mediumVO;
            mode = difficulty.medium;
        }
        audio.Play();
        PlayerPrefs.SetInt("difficulty", (int)mode);
    }
}
