using UnityEngine;

public class LoadProgress : MonoBehaviour
{
    private void Awake()
    {
        if (PlayerPrefs.HasKey("Progress"))
        {
            StartGame.CurrentCarLevel = PlayerPrefs.GetInt("Progress");
        }
        else
        {
            StartGame.CurrentCarLevel = 1;
        }
    }
}