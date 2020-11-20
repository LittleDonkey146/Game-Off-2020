using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{

    public AudioMixer audioMixer;
    public Slider slider;
    public float sliderValue;

    private void Start()
    {

    }

    public void SetVolume(float volume)
    {
        
        sliderValue = volume;
        audioMixer.SetFloat("volume", volume);
    }

    public void BackButton()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
