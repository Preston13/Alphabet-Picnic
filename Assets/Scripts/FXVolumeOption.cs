using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class FXVolumeOption : MonoBehaviour
{

    public Slider fxVolumeSlider;
    public AudioMixer mixer;
    public float volume = 0f;

    // Start is called before the first frame update
    void Start()
    {
        volume = PlayerPrefs.GetFloat("fxVolume");
        fxVolumeSlider.value = volume;
    }

    // Update is called once per frame
    void Update()
    {        
        mixer.SetFloat("volume", fxVolumeSlider.value);
        PlayerPrefs.SetFloat("fxVolume", fxVolumeSlider.value);
    }
}
