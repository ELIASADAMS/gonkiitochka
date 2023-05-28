using UnityEngine;
using TMPro;

public class FinishCheckpoint : MonoBehaviour
{
    [Header("Finish")]
    [SerializeField] private GameObject _finish_panel;
    [SerializeField] private int _number_next_level;

    [Space]
    [Header("Race result")]
    [SerializeField] private PlayerPlaceInRaceCircle _player_place;
    [SerializeField] private TMP_Text _text_race_result;
    private string _win = "онгдпюбкъел бш онаедхкх";
    private string _win_timer = "онгдпюбкъел бш сяоекх";
    private string _lose = "бш опнхцпюкх онопнасире еы╗ пюг";
    private string _lose_timer = "бш ме сяоекх онопнасире еы╗ пюг";

    private void Awake()
    {
        _finish_panel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CursorStates.Instance.GameOver();
            _finish_panel.SetActive(true);
            gameObject.SetActive(false);
            if (PlayerPlaceInRaceTimer.Instance != null)
            {
                if (PlayerPlaceInRaceTimer.Instance.CheckWin())
                {
                    _text_race_result.text = _win_timer;
                }
                else
                {
                    _text_race_result.text = _lose_timer;
                }
            }
            //else if (PlayerPlaceInRaceSprint.Instance != null)
            //{
            //    if (PlayerPlaceInRaceSprint.Instance.PlayerPlace == 1)
            //    {
            //        _text_race_result.text = _win;
            //    }
            //    else
            //    {
            //        _text_race_result.text = _lose;
            //    }
            //}

           
        }
    }
}