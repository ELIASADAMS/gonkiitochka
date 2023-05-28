using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScenes : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private string _scene_name;

    private void Start()
    {
        _slider.minValue = 0;
        _slider.maxValue = 1;
        _slider.value = 0;
        StartCoroutine(Loading());
    }

    private IEnumerator Loading()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(_scene_name);
        while (!operation.isDone)
        {
            float progress = operation.progress / 0.9f;
            _slider.value = progress;
            yield return null;
        }
    }
}