using UnityEngine;

public class ChooseLevel : MonoBehaviour
{
    [SerializeField] private GameObject[] _levels;
    [SerializeField] private GameObject _freeway;
    [SerializeField] private GameObject _arrow;

    private void Awake()
    {
        foreach (var level in _levels)
        {
            level.SetActive(false);
        }
        _freeway.SetActive(false);
    }

    private void Start()
    {
        if (StartGame.CarClass == 1 || StartGame.CarLevel == 4)
        {
            _freeway.SetActive(true);
            _arrow.SetActive(false);
        }
        else if (StartGame.CurrentCarLevel > 0)
        {
            if (StartGame.CurrentCarLevel != 1)
            {
                Counter.Instance.Countdown();
            }
            _levels[StartGame.CurrentCarLevel - 1].SetActive(true);
        }
    }
}