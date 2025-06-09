using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    [Header("Audio")]
    [SerializeField] private AudioSource _main_sound;
    [SerializeField] private TMP_Text _text_main_sound;
    [SerializeField] private Slider _slider_main_sound;

    private int _slider_main_volume = 50;
    private void Start()
    {
        _slider_main_sound.minValue = 0;
        _slider_main_sound.maxValue = 100;
        _slider_main_sound.value = _slider_main_volume;
        _text_main_sound.text = _slider_main_volume.ToString();
        _main_sound.volume = _slider_main_volume / 100f;
    }

    public void ChangeVolume()
    {
        _slider_main_volume = (int)_slider_main_sound.value;
        _text_main_sound.text = _slider_main_volume.ToString();
        _main_sound.volume = (float)_slider_main_volume / 100f;
    }

    public void SetQuality(int value)
    {
        QualitySettings.SetQualityLevel(value);
        PlayerPrefs.SetInt("Quality", value);
    }
}