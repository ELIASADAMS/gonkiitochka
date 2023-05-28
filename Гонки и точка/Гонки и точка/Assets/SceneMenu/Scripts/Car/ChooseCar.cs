using UnityEngine;
using TMPro;

public class ChooseCar : MonoBehaviour
{ 
    // variables
    #region
    public static ChooseCar Instance;

    [Header("Cars")]
    [SerializeField] private CarMenu[] _cars;
    [Space]
    [Header("Texts")]
    [SerializeField] private TMP_Text _text_description_car;
    [SerializeField] private TMP_Text _text_name_car;
    [SerializeField] private TMP_Text _text_steering_car;
    [SerializeField] private TMP_Text _text_nitro_car;
    [SerializeField] private TMP_Text _text_level_car;
    [SerializeField] private TMP_Text _text_max_speed_car;
    private int _number_selecred_car;
    private PlayerProgress _playerProgress;
    #endregion

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        _playerProgress = PlayerProgress.Instance;
        foreach(var car in _cars)
        {
            car.gameObject.SetActive(false);
        }
        _number_selecred_car = StartGame.NumberSelectedCar;
        ShowCar();
    }

    public void NextCar()
    {
        _cars[_number_selecred_car].gameObject.SetActive(false);
        _number_selecred_car++;
        if (_number_selecred_car >= _cars.Length)
        {
            _number_selecred_car = 0;
        }
        ShowCar();
    }

    public void BackCar()
    {
        _cars[_number_selecred_car].gameObject.SetActive(false);
        _number_selecred_car--;
        if (_number_selecred_car < 0)
        {
            _number_selecred_car = _cars.Length - 1;
        }
        ShowCar();
    }

    private void ShowCar()
    {
        _cars[_number_selecred_car].gameObject.SetActive(true);
        _text_description_car.text = _cars[_number_selecred_car].Description;
        _text_steering_car.text = _cars[_number_selecred_car].Steering.ToString();
        _text_name_car.text = _cars[_number_selecred_car].Name;
        _text_nitro_car.text = _cars[_number_selecred_car].Nitro;
        _text_level_car.text = _cars[_number_selecred_car].Level.ToString();
        _text_max_speed_car.text = _cars[_number_selecred_car].MaxSpeed.ToString();
        if (_number_selecred_car % 2 == 0)
        {
            StartGame.CarClass = 2;
        }
        else
        {
            StartGame.CarClass = 1;
        }
        StartGame.NumberSelectedCar = _number_selecred_car;
        StartGame.CarLevel = _cars[_number_selecred_car].Level;
        _playerProgress.ClosePanel();
    }
}