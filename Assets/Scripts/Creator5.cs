using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Creator5 : MonoBehaviour
{
    public GameObject letterSprite;
    

    public void CreateWord(Sprite word, bool isCorrect)
    {
        letterSprite.GetComponent<WordMover>().isCorrect = isCorrect;
        
        letterSprite.GetComponent<SpriteRenderer>().sprite = word;

        Instantiate(letterSprite, this.transform);
    }
}
