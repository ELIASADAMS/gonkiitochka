using UnityEngine;

public class PlaceChecker : MonoBehaviour
{
    public string Name;
    private void Start()
    {
        if (gameObject.GetComponent<RCC_AICarController>())
        {
            Name = "bot";
        }
        else
        {
            Name = "player";
        }
        PlayerPlaceInRaceSprint.Instance.AddPlaceChecker = this;
    }
}