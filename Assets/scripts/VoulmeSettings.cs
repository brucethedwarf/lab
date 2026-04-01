using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VoulmeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider BackgroundSlider;


    public void SetBackgroundVolume()
    {
        float voulme = BackgroundSlider.value;
        myMixer.SetFloat("Background", voulme);
    }

}
