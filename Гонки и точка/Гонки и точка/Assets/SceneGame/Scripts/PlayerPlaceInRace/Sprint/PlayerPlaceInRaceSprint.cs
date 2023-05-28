using UnityEngine;
using TMPro;
using System.Collections.Generic;
using System.Collections;

public class PlayerPlaceInRaceSprint : MonoBehaviour
{
    public static PlayerPlaceInRaceSprint Instance;

    public int PlayerPlace { get { return _player_place; } }
    public PlaceChecker AddPlaceChecker { set { _place.Add(value); } }

    [SerializeField] private GameObject _lap_text;
    [SerializeField] private GameObject _player_place_text;
    [SerializeField] private TMP_Text _text_player_place;
    [SerializeField] private TMP_Text _text_recers_all;
    [SerializeField] private List<PlaceChecker> _place;

    [SerializeField] private int _player_place;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        _lap_text.SetActive(false);
        _player_place_text.SetActive(false);
        StartCoroutine(StartPlacePlayer());
    }

    private IEnumerator StartPlacePlayer()
    {
        yield return new WaitForSeconds(1);
        for (int i = 0; i < _place.Count; i++)
        {
            if (_place[i].Name == "player")
            {
                _player_place = i + 1;
            }
        }
        _text_player_place.text = _player_place.ToString();
        _text_recers_all.text = _place.Count.ToString();
    }
}