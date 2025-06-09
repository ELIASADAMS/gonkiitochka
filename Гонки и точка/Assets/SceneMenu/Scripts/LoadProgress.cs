using UnityEngine;

public class LoadProgress : MonoBehaviour
{
    private void Awake()
    {
        if (PlayerPrefs.HasKey("Progress"))
        {
            StartGame.CarLevel = PlayerPrefs.GetInt("Progress");
        }
        else
        {
            StartGame.CarLevel = 1;
        }

    }
}