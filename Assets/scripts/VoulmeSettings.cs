using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VoulmeSettings : MonoBehaviour
{
    public AudioMixer myMixer;
    public Slider backgroundSlider;
    public Slider masterSlider;


    private void Start()
    {
        backgroundSlider.value = PlayerPrefs.GetFloat("Background", 1);
        masterSlider.value = PlayerPrefs.GetFloat("Master", 1);
        myMixer.SetFloat("Background", PlayerPrefs.GetFloat("Background", 1));
        myMixer.SetFloat("Master", PlayerPrefs.GetFloat("Master", 1));
    }

    public void SetBackgroundVolume(float voulme)
    {
        myMixer.SetFloat("Background", voulme);
        PlayerPrefs.SetFloat("Background", voulme);
    }

    public void SetMasterVolume(float voulme)
    {
        myMixer.SetFloat("Master", voulme);
        PlayerPrefs.SetFloat("Master", voulme);
    }

}
