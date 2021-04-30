using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeChangeScript : MonoBehaviour
{

    public AudioMixer mixer;
    
    Slider slider;

    void Start() {
        //gets slider and sets the value to the saved playerpref
        slider = GetComponent<Slider>();
        slider.value = PlayerPrefs.GetFloat("sliderVal");
    }
    //changes volume and sets a playerprefs so that the chosen volume is saved
    public void setVal(float sliderVal){
        mixer.SetFloat("Volume", Mathf.Log10(sliderVal)*20);
        PlayerPrefs.SetFloat("sliderVal", sliderVal);
    }
}
