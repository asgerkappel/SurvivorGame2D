using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public void Start(){
        if(PlayerPrefs.HasKey("Volume")){
            LoadVolume();
        }
        else{
        SetVolume();
        }
    }

    public void SetVolume()
    {
        float volume = musicSlider.value;
        myMixer.SetFloat("music", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("Volume", volume);
    }

    private void LoadVolume(){
        musicSlider.value=PlayerPrefs.GetFloat("Volume");
        SetVolume();
    }

    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider musicSlider;
}
