using UnityEngine;

public class PlayerProgress : MonoBehaviour
{
    public static PlayerProgress Instance;

    [SerializeField] private GameObject _panel_close;

    private void Awake()
    {
        Instance = this;
        _panel_close.SetActive(false);
    }

    public void ClosePanel()
    {
        if(StartGame.CarLevel <= StartGame.CurrentCarLevel)
            _panel_close.SetActive(false);
        else
            _panel_close.SetActive(true);
    }
}