using UnityEngine;
/*
 * 0 - Simulator
 * 1 - Racing
 * 2 - Drift
 * 3 - Semi Arcade
 * 4 - Fun
 */
public class SelectCar : MonoBehaviour
{
    public static SelectCar Instance;

    public int CurrentCheckpoint = 0;
    public int CurrentLap = 1;

    [SerializeField] private Rigidbody _rigidbody;

    [SerializeField] private GameObject[] _lights;
    [SerializeField] private GameObject[] _break_lights;
    private bool _lights_enable = true;

    private void Awake()
    {
        Instance = this;
        int behavior;
        if (StartGame.CarClass == 2)
        {
            _rigidbody.useGravity = false;
            _rigidbody.isKinematic = true;
            behavior = 1;
        }
        else
        {
            behavior = 2;
        }
        if (StartGame.CarLevel == 4)
        {
            behavior = 2;
        }
        RCC.SetBehavior(behavior);
    }

    private void Start()
    {
        CursorStates.Instance.SetCarAudio(GetComponentsInChildren<AudioSource>());
        foreach (var light in _lights)
        {
            light.SetActive(_lights_enable);
        }
        foreach (var light in _break_lights)
        {
            light.SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            _lights_enable = !_lights_enable;
            foreach (var light in _lights)
            {
                light.SetActive(_lights_enable);
            }
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            foreach (var light in _break_lights)
            {
                light.SetActive(true);
            }
        }
        else
        {
            foreach (var light in _break_lights)
            {
                light.SetActive(false);
            }
        }
    }

    public void RaceCar()
    {
        _rigidbody.useGravity = true;
        _rigidbody.isKinematic = false;
    }
}