using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseCondition : MonoBehaviour
{
    public ScoreKeeper scoreKeep;
    public SceneChanger sceneChanger;
    public int missesAllowed = 3;
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;
    public GameObject life4;
    public GameObject life5;
    public SpriteRenderer bear;

    private int misses = 0;
    private int mode;
    private List<GameObject> lives = new List<GameObject>();
    private AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
        life1.SetActive(true);
        lives.Add(life1);
        life2.SetActive(true);
        lives.Add(life2);
        life3.SetActive(true);
        lives.Add(life3);

        mode = PlayerPrefs.GetInt("difficulty");
        if (mode == (int)Difficulty.difficulty.hard)
        {
            missesAllowed =3;
        }
        else if (mode == (int)Difficulty.difficulty.medium)
        {
            missesAllowed = 4;
            life4.SetActive(true);
            lives.Add(life4);
        }
        else
        {
            missesAllowed = 5;
            life4.SetActive(true);
            lives.Add(life4);
            life5.SetActive(true);
            lives.Add(life5);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<WordMover>().isCorrect)
        {
            misses++;
            Destroy(lives[lives.Count - misses]);
            StartCoroutine(TakeDamage(bear, Color.red, 1));
            audio.Play();
        }

        if (misses == missesAllowed)
        {
            PlayerPrefs.SetInt("lastScore", scoreKeep.score);
            sceneChanger.ChangeScene("LoseScene");
        }
    }

    IEnumerator TakeDamage(SpriteRenderer sr, Color dmgColor, float duration)
    {
        Color originColor = sr.color;

        sr.color = dmgColor;

        for (float t = 0; t < 1.0f; t += Time.deltaTime / duration)
        {
            sr.color = Color.Lerp(dmgColor, originColor, t);

            yield return null;
        }

        sr.color = originColor;
    }
}
