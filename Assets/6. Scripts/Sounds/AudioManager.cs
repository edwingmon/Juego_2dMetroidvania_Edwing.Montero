using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{

    public AudioMixer musicMixer, masterMixer;

    public AudioSource backgroundMusic, hit, enemyDead, gems;

    public static AudioManager instance;

    [Range(-80, 10)]
    public float masterVol, musicVol;
    public Slider masterSldr, musicSldr;

    // Start is called before the first frame update
    void Start()
    {
        PlayAudio(backgroundMusic);
        masterSldr.value = masterVol;
        musicSldr.value = musicVol;
    }

    // Update is called once per frame
    void Update()
    {
        MasterVolume();
        MusicVolume();

        masterSldr.minValue = -80;
        masterSldr.maxValue = 10;

        musicSldr.minValue = -80;
        musicSldr.maxValue = 10;
    }

    public void MasterVolume()
    {
        masterMixer.SetFloat("masterVolume", masterSldr.value);
    }

    public void MusicVolume()
    {
        musicMixer.SetFloat("musicVolume", musicSldr.value);
    }

    public void PlayAudio(AudioSource audio) {
        audio.Play();
    }
}
