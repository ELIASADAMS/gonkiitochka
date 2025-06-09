using UnityEngine;
using System;
using System.Collections;
using TMPro;

public class Checkpoints : MonoBehaviour
{
    public static Checkpoints Instance;

    public bool IsCircle { get { return _is_circle; } set { _is_circle = value; } }
    public int CurrentWaypoint { get { return _current_checkpoint; } }
    public int Lap { get { return _current_lap; } }

    [SerializeField] private TMP_Text _text_checkpoints;
    [SerializeField] private GameObject[] _checkpoints;
    [SerializeField] private GameObject _finish_checkpoints;
    private int _current_checkpoint = 0;

    [Space]
    [Header("Circle")]
    [SerializeField] private bool _is_circle;
    [SerializeField] private TMP_Text _text_lap;
    [SerializeField] private int _max_lap;
    private int _current_lap = 1;
    private bool finish = false;

    private void Awake()
    {
        _finish_checkpoints.SetActive(false);
        Instance = this;
    }

    private void Start()
    {
        foreach (var checkpoint in _checkpoints)
        {
            checkpoint.SetActive(false);
        }
        _checkpoints[_current_checkpoint].SetActive(true);
        _text_checkpoints.text = $"“Œ◊ »: {_current_checkpoint}/{_checkpoints.Length}";
        if (_is_circle)
        {
            _text_lap.text = $" –”√»: {_current_lap}/{_max_lap}";
        }
    }

    public Vector3 CurrentCheckpoint()
    {
        if (finish)
        {
            return _finish_checkpoints.transform.position;
        }
        return _checkpoints[_current_checkpoint].transform.position;
    }

    public void NextCheckpoint()
    {
        _checkpoints[_current_checkpoint].SetActive(false);
        _current_checkpoint++;
        if (_current_checkpoint < _checkpoints.Length)
        {
            _checkpoints[_current_checkpoint].SetActive(true);
            SelectCar.Instance.CurrentCheckpoint = _current_checkpoint;
        }
        else
        {
            _current_lap++;
            SelectCar.Instance.CurrentCheckpoint = 0;
            SelectCar.Instance.CurrentLap = _current_lap;
            if (_current_lap <= _max_lap)
            {
                _current_checkpoint = 0;
                _checkpoints[_current_checkpoint].SetActive(true);
                _text_lap.text = $" –”√»: {_current_lap}/{_max_lap}";
            }
            else
            {
                finish = true;
                _finish_checkpoints.SetActive(true);
            }
        }
        _text_checkpoints.text = $"“Ó˜ÍË: {_current_checkpoint}/{_checkpoints.Length}";
    }

    
}