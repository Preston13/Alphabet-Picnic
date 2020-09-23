using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catcher : MonoBehaviour
{
    public ScoreKeeper scoreKeep;

    private AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<WordMover>().isCorrect)
        {
            scoreKeep.UpdateScore();
            Invoke("PlayYum", .5f);
        }
        else
        {
            scoreKeep.UpdatePenalty();   
        }
        
        Destroy(collision.gameObject);
    }    

    private void PlayYum()
    {
        audio.Play();
    }
}
