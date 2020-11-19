using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Options : MonoBehaviour
{

    public AudioMixer audioMixer;
    public float slider;

    public void SetVolume(float volume)
    {
        slider = GetComponent<Slider>().value;
        volume = slider;
        audioMixer.SetFloat("volume", volume);
    }
}
