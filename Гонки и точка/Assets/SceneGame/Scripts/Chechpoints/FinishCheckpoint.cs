using UnityEngine;
using TMPro;

public class FinishCheckpoint : MonoBehaviour
{
    [Header("Finish")]
    [SerializeField] private GameObject _finish_panel;
    [SerializeField] private int _number_next_level;

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
            if (_number_next_level > StartGame.CarLevel)
            {
                StartGame.CarLevel = _number_next_level;
                PlayerPrefs.SetInt("Progress", StartGame.CarLevel);
            }
        }
    }
}