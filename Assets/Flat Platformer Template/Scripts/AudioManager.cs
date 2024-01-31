using UnityEngine;
using UnityEngine.UIElements;

public class AudioManager : MonoBehaviour
{
    [Header("-------- Audio Source --------")]
    [SerializeField] AudioSource musicSource;

    [Header("-------- Audio Clip --------")]
    public AudioClip Background;
    public AudioClip NextLevel;

    private void Start(){
        musicSource.clip = Background;
        musicSource.loop = true; //Sætter musikken i et loop
        musicSource.Play(); //Starter musikken når man kommer ind
    }
}
