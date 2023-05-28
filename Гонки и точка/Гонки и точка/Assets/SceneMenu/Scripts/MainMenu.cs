using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _panel_settings;
    [SerializeField] private GameObject _panel_close;

    private void Awake()
    {
        _panel_settings.SetActive(false);
    }

    public void ButtonStart()
    {
        if (_panel_close.activeInHierarchy == false)
        {
            SceneManager.LoadScene("LoadingGame");
        }
    }

    public void ButtonQuit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#elif UNITY_STANDALONE
        Application.Quit();
        PlayerPrefs.SetInt("Progress", StartGame.CurrentCarLevel);
#endif
    }

    public void ButtonSettings()
    {
        _panel_settings.SetActive(true);
        StartCoroutine(CloseSettings());
    }

    public void ButtonBack()
    {
        _panel_settings.SetActive(false);
    }

    private IEnumerator CloseSettings()
    {
        while (true)
        {
            yield return new WaitForSeconds(Time.deltaTime);
            if (Input.GetKey(KeyCode.Escape))
            {
                _panel_settings.SetActive(false);
                break;
            }
        }
    }
}