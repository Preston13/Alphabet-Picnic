using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class TutorialScript : MonoBehaviour
{
    public AudioSource tutorialAudio;
    public AudioClip finishTutorial;
    public SceneChanger scene;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!tutorialAudio.isPlaying)
        {
            tutorialAudio.clip = finishTutorial;
            tutorialAudio.Play();
            Destroy(collision.gameObject);
            Invoke("Finish", 6);
        }
    }

    private void Finish()
    {
        scene.ChangeScene("SampleScene");
    }
}
