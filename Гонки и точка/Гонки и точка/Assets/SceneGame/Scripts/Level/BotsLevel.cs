using UnityEngine;

public class BotsLevel : MonoBehaviour
{
    public static BotsLevel Instance;

    [SerializeField] private RCC_AICarController[] _bots;

    private void Awake()
    {
        Instance = this;
        foreach (var bot in _bots)
        {
            bot.enabled = false;
        }
    }

    public void StartRace()
    {
        foreach (var bot in _bots)
        {
            bot.enabled = true;
        }
    }
}