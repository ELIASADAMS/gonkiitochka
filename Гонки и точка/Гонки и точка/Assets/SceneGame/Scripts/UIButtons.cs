using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIButtons : MonoBehaviour
{
    public static UIButtons Instance;

    [SerializeField] private CursorStates _cursor;
    [Header("Panels")]
    [SerializeField] private GameObject _panel_settings;
    [SerializeField] private GameObject _panel_buttons;
    [SerializeField] private GameObject _panel_finish;

    [Space]
    [Header("Interface")]
    [SerializeField] private GameObject[] _interface;
    [SerializeField] private TMP_Text _text_button;
    private bool _inerface_enable = false;
    private string off = "¬€ À";
    private string on = "¬ À";

    private void Awake()
    {
        Instance = this;
        _panel_settings.SetActive(false);
        _panel_buttons.SetActive(true);
    }

    public void ButtonContinue()
    {
        _cursor.Continue();
    }

    public void ButtonMenu()
    {
        SceneManager.LoadScene("LoadingMenu");
    }

    public void ButtonSettings()
    {
        _panel_settings.SetActive(true);
        _panel_buttons.SetActive(false);
    }

    public void ButtonBackSettings()
    {
        _panel_settings.SetActive(false);
        _panel_buttons.SetActive(true);
    }

    public void ButtonContinueFinish()
    {
        _panel_finish.SetActive(false);
    }

    public void ButtonRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ButtonInterface()
    {
        foreach (var item in _interface)
        {
            item.SetActive(_inerface_enable);
        }
        _inerface_enable = !_inerface_enable;
        _text_button.text = _inerface_enable ? on : off;
    }
}