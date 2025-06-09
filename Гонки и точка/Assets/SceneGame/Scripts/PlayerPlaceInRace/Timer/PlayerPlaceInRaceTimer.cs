using UnityEngine;
using TMPro;
using System.Collections;
using System;

public class PlayerPlaceInRaceTimer : MonoBehaviour
{
    public static PlayerPlaceInRaceTimer Instance;

    [SerializeField] private TMP_Text _text_lap;
    [SerializeField] private GameObject _player_place;
    private float _timer = 170f;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        _player_place.SetActive(false);
        StartCoroutine(Timer());
    }

    public bool CheckWin()
    {
        return _timer > 0;
    }

    private IEnumerator Timer()
    {
        _text_lap.text = $"ÂÐÅÌß: {_timer}";
        yield return new WaitForSeconds(4);
        while (_timer > 0)
        {
            _text_lap.text = $"ÂÐÅÌß: {String.Format("{0:0.0}", _timer)}";
            _timer -= 0.1f;
            yield return new WaitForSeconds(0.1f);
        }
    }
}