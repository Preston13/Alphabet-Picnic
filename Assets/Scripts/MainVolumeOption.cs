using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MainVolumeOption : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioMixer mixer;
    public float volume = 0f;

    // Start is called before the first frame update
    void Start()
    {
       volume = PlayerPrefs.GetFloat("mainVolume");
       volumeSlider.value = volume;
    }

    // Update is called once per frame
    void Update()
    {       
        mixer.SetFloat("volume", volumeSlider.value);
        PlayerPrefs.SetFloat("mainVolume", volumeSlider.value);
    }
}
