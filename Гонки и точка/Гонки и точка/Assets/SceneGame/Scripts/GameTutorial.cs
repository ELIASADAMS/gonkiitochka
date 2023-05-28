using UnityEngine;
using System.Collections;

public class GameTutorial : MonoBehaviour
{
    public static GameTutorial Instance;

    [SerializeField] private GameObject _canvas_tutorial;

    private void Awake()
    {
        Instance = this;   
        
    }

    private void Start()
    {
        StartCoroutine(ShowCursor());
        StartCoroutine(CloseTutorial());
    }

    public void ButtonClose()
    {
        CursorStates.Instance.Continue();
        _canvas_tutorial.SetActive(false);
        Counter.Instance.Countdown();
    }

    private IEnumerator ShowCursor()
    {
        yield return new WaitForSeconds(0.5f);
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    private IEnumerator CloseTutorial()
    {
        CursorStates.Instance.IsGameOver = true;
        bool value = true;
        while (value)
        {
            yield return new WaitForSeconds(Time.deltaTime);
            if (Input.GetKey(KeyCode.Escape))
            {
                CursorStates.Instance.IsGameOver = false;
                ButtonClose();
                value = false;
            }
        }
    }
}