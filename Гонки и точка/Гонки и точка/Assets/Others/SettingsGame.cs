using UnityEngine;

public class SettingsGame : MonoBehaviour
{
    private void Awake()
    {
        if (PlayerPrefs.HasKey("Quality"))
        {
            QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("Quality"));
        }
        else
        {
            QualitySettings.SetQualityLevel(2);
            PlayerPrefs.SetInt("Quality", 2);
        }
    }
}