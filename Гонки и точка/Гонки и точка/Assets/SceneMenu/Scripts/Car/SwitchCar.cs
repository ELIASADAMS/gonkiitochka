using UnityEngine;

public class SwitchCar : MonoBehaviour
{
    [SerializeField] private bool _is_right;

    public void ButtonSwitchLeft()
    {
        ChooseCar.Instance.BackCar();
    }

    public void ButtonSwitchRight()
    {
        ChooseCar.Instance.NextCar();
    }
}