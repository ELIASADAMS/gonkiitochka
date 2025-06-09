using System.Collections;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    public static Counter Instance;

    [SerializeField] private TMP_Text _text_counter;
    private int _seconds = 3;

    private void Awake()
    {
        Instance = this;
    }

    public void Countdown()
    {
        StartCoroutine(Counter_());
    }

    private IEnumerator Counter_()
    {
        _text_counter.text = _seconds.ToString();
        yield return new WaitForSeconds(1);
        while (_seconds > 1)
        {
            _seconds--;
            _text_counter.text = _seconds.ToString();
            yield return new WaitForSeconds(1);
        }
        _text_counter.text = "бвРав";
        if (BotsLevel.Instance != null)
        {
            BotsLevel.Instance.StartRace();
        }
        SelectCar.Instance.RaceCar();
        yield return new WaitForSeconds(1);
        _text_counter.text = "";
        _text_counter.gameObject.SetActive(false);
    }
}