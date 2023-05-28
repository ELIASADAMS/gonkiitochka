using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public static BackgroundMusic Instance;

    [SerializeField] private AudioSource _audio_source;
    [SerializeField] private AudioClip _level_1;
    [SerializeField] private AudioClip _level_2;
    [SerializeField] private AudioClip _level_3;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        switch (StartGame.CarLevel)
        {
            case 1:
                _audio_source.clip = _level_1;
                break;
            case 2:
                _audio_source.clip = _level_2;
                break;
            case 3:
                _audio_source.clip = _level_3;
                break;
        }
        MusicPlay();
    }

    public void MusicPlay()
    {
        _audio_source.Play();
    }

    public void MusicStop()
    {
        _audio_source.Stop();
    }
}