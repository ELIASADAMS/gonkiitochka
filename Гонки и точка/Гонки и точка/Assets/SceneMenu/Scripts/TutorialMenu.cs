using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class TutorialMenu : MonoBehaviour
{
    [Header("Game Objects")]
    [SerializeField] private CameraRotate _camera_rotate;
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Button _button_game;
    [SerializeField] private Button _button_settings;
    [SerializeField] private GameObject _panel_description;
    [Space]
    [Header("Tutorial Object")]
    [SerializeField] private GameObject _panel_switch_car;
    [SerializeField] private GameObject _panel_tutorial_switch_car;
    [SerializeField] private GameObject _arrows;
    private string _greeting_text = "Добро пожаловать в игру ''ГОНКИ И ТОЧКА''\n" +
        "Здесь вы прокатитесь на легендарных авто СССР\n" +
        "Получите много эмоций";
    private string _select_car_text = "Для выбора автомобиля нажмите " +
        "на одну из кнопок внизу";
    private string _description_car_text = "Справа написаны характеристики машины";
    private string _finish_text = "Благодарим за прохождение краткого обучения\n" +
        "Надеемся на Вашу победу:)";
    private bool _pressed = true;

    private void Awake()
    {
        if (StartGame.TutorialMenu)
        {
            _camera_rotate.enabled = false;
            _panel_switch_car.SetActive(false);
            _panel_tutorial_switch_car.SetActive(false);
            _arrows.SetActive(false);
            _panel_description.SetActive(false);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    private void Start()
    {
        if (StartGame.TutorialMenu)
        {
            print(1);
            StartCoroutine(PrintGreetingText());
        }
        else
        {
            print(2);
        }
    }

    public void ButtonChangeCar()
    {
        if (_pressed)
        {
            _text.text = "";
            _arrows.SetActive(false);
            StartCoroutine(PrintDescriptionCarText());
            _pressed = false;
        }
    }

    private IEnumerator PrintGreetingText()
    {
        int index = 0;
        while (index < _greeting_text.Length)
        {
            _text.text += _greeting_text[index].ToString();
            index++;
            yield return new WaitForSeconds(0.05f);
        }
        yield return new WaitForSeconds(3);
        _text.text = "";
        StartCoroutine(PrintSelectCarText());
    }

    private IEnumerator PrintSelectCarText()
    {
        int index = 0;
        while (index < _select_car_text.Length)
        {
            _text.text += _select_car_text[index].ToString();
            index++;
            yield return new WaitForSeconds(0.05f);
        }
        _arrows.SetActive(true);
        _panel_tutorial_switch_car.SetActive(true);
        yield return new WaitForSeconds(1);
    }

    private IEnumerator PrintDescriptionCarText()
    {
        int index = 0;
        _panel_description.SetActive(true);
        while (index < _description_car_text.Length)
        {
            _text.text += _description_car_text[index].ToString();
            index++;
            yield return new WaitForSeconds(0.05f);
        }
        yield return new WaitForSeconds(3);
        _text.text = "";
        StartCoroutine(PrintFinishText());
    }

    private IEnumerator PrintFinishText()
    {
        int index = 0;
        while (index < _finish_text.Length)
        {
            _text.text += _finish_text[index].ToString();
            index++;
            yield return new WaitForSeconds(0.05f);
        }
        yield return new WaitForSeconds(2);
        _panel_switch_car.SetActive(true);
        gameObject.SetActive(false);
        _camera_rotate.enabled = true;
        _button_game.interactable = true;
        _button_settings.interactable = true;
        StartGame.TutorialMenu = false;
    }
}