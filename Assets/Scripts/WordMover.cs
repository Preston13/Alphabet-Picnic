using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordMover : MonoBehaviour
{
    public float moveSpeed = 100f;
    public bool isCorrect = false;
    public AudioClip[] letterClips;

    public int mode;

    private AudioSource letterAudio;

    private void Start()
    {
        letterAudio = GetComponent<AudioSource>();
        mode = PlayerPrefs.GetInt("difficulty");
        if (mode == (int)Difficulty.difficulty.hard)
        {
            moveSpeed = 6f;
        }
        else if (mode == (int)Difficulty.difficulty.medium)
        {
            moveSpeed = 4f;
        }
        else
        {
            moveSpeed = 2f;
        }
        if (isCorrect)
        {
            foreach(AudioClip letterSound in letterClips)
            {
                if(letterSound.name[0] == GetComponent<SpriteRenderer>().sprite.name[23])
                {
                    letterAudio.clip = letterSound;
                    letterAudio.PlayOneShot(letterSound);
                    break;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {       
        this.transform.position -= new Vector3(0, 1, 0) * moveSpeed * Time.deltaTime;
    }
}
