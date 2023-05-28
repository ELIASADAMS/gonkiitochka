using UnityEngine;
using System.Collections.Generic;

public class CursorStates : MonoBehaviour
{
    public static CursorStates Instance;

    public bool IsGameOver { get { return _game_over; } set { _game_over = value; } }

    [SerializeField] private GameObject _pause_panel;
    [SerializeField] private List<AudioSource> _car_audio;
    private bool _is_pause = false;
    private bool _game_over = false;

    private void Awake()
    {
        _car_audio = new();
        Instance = this;
    }

    private void Start()
    {
        Continue();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && _game_over == false)
        {
            _is_pause = !_is_pause;
            if (_is_pause)
            {
                Pause();
            }
            else
            {
                Continue();
            }
        }
    }

    public void GameOver()
    {
        _game_over = true;
        StateCursor(true);
    }

    public void SetCarAudio(AudioSource[] audios)
    {
        foreach (var audio in audios)
        {
            _car_audio.Add(audio);
        }
    }

    public void Continue()
    {
        Time.timeScale = 1;
        StateCursor();
        _pause_panel.SetActive(false);
        foreach (var audio in _car_audio)
        {
            audio.Play();
        }
        BackgroundMusic.Instance.MusicPlay();
    }

    private void Pause()
    {
        UIButtons.Instance.ButtonBackSettings();
        Time.timeScale = 0;
        StateCursor(true);
        _pause_panel.SetActive(true);
        foreach (var audio in _car_audio)
        {
            audio.Pause();
        }
        BackgroundMusic.Instance.MusicStop();
    }

    private void StateCursor(bool visible = false)
    {
        if (visible)
        {
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}