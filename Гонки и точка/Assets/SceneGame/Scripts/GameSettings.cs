using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameSettings : MonoBehaviour
{

    [SerializeField] private TMP_Text _text_volume_music;
    [SerializeField] private Slider _slider_volume_music;
    [SerializeField] private AudioSource _audio_music;
    private int _volume_music = 50;

    private void Start()
    {
        _audio_music.volume = (float)_volume_music / 100f;
        _text_volume_music.text = _volume_music.ToString();
        _slider_volume_music.minValue = 0;
        _slider_volume_music.maxValue = 100;
        _slider_volume_music.value = _volume_music;
    }

    public void ChangeVolumeMusic(float volume)
    {
        _volume_music = (int)volume;
        _text_volume_music.text = _volume_music.ToString();
        _audio_music.volume = (float)_volume_music / 100f;
    }

    public void SetQuality(int value)
    {
        QualitySettings.SetQualityLevel(value);
        PlayerPrefs.SetInt("Quality", value);
    }
}