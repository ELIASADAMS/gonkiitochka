using UnityEngine;

public class Freeway : MonoBehaviour
{
    [SerializeField] private GameObject _counter;
    [SerializeField] private GameObject _race_panel;

    private void Start()
    {
        _counter.SetActive(false);
        _race_panel.SetActive(false);
    }
}