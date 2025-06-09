using UnityEngine;
using TMPro;

public class PlayerPlaceInRaceCircle : MonoBehaviour
{
    public int PlayerPlace { get { return _player_place; } }

    [Header("Racers")]
    [SerializeField] private BotDistance[] _bots;
    [SerializeField] private PlayerDistance _player;

    [Space]
    [Header("Texts")]
    [SerializeField] private TMP_Text _player_text;
    [SerializeField] private TMP_Text _all_text;

    private int _player_place;

    private void Start()
    {
        //_all_text.text = (_bots.Length + 1).ToString();
        //SetPlayerPlace();
    }

    //private void LateUpdate()
    //{
    //    SetPlayerPlace();
    //}

    //private void SetPlayerPlace()
    //{
    //    SortLap();
        
    //}

    //private void SortLap()
    //{
    //    bool sort = true;
    //    while (sort)
    //    {
    //        sort = false;
    //        for (int i = 0; i < _bots.Length - 1; i++)
    //        {
    //            if (_bots[i].LapNumber < _bots[i + 1].LapNumber)
    //            {
    //                var temp = _bots[i];
    //                _bots[i] = _bots[i + 1];
    //                _bots[i + 1] = temp;
    //                sort = true;
    //            }
    //        }
    //    }
    //}

    //private void SortWaypoint(int index)
    //{
    //    bool sort = true;
    //    while (sort)
    //    {
    //        sort = false;
    //        for (int i = index; i < _bots.Length - 1; i++)
    //        {
    //            if (_bots[i].WaypointNumber < _bots[i + 1].WaypointNumber)
    //            {
    //                var temp = _bots[i];
    //                _bots[i] = _bots[i + 1];
    //                _bots[i + 1] = temp;
    //                sort = true;
    //            }
    //        }
    //    }
    //}

    //private void SortDistance(int index)
    //{
    //    bool sort = true;
    //    while (sort)
    //    {
    //        sort = false;
    //        for (int i = index; i < _bots.Length - 1; i++)
    //        {
    //            if (_bots[i].DistanceCurrentWaypoint > _bots[i + 1].DistanceCurrentWaypoint)
    //            {
    //                var temp = _bots[i];
    //                _bots[i] = _bots[i + 1];
    //                _bots[i + 1] = temp;
    //                sort = true;
    //            }
    //        }
    //    }
    //}
}
