using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
    private Image btn;

    public Sprite pauseSprite;
    public Sprite playSprite;

    // Start is called before the first frame update
    void Start()
    {
        btn = GetComponent<Image>();
    }

    public void Pause()
    {
        if (Time.timeScale == 0)
        {
            btn.sprite = pauseSprite;
            Time.timeScale = 1;
        }
        else
        {
            btn.sprite = playSprite;
            Time.timeScale = 0;
        }
    }
}
