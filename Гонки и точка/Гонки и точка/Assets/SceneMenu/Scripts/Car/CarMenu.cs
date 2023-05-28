using UnityEngine;

public class CarMenu : MonoBehaviour
{
    public string Description { get { return _description; } }
    public string Name { get { return _name; } }
    public float Steering { get { return _steering; } }
    public string Nitro { get { return _nitro; } }
    public int Level { get { return _level; } }
    public int MaxSpeed { get { return _max_speed; } }

    [SerializeField] private string _description;
    [SerializeField] private string _name;
    [SerializeField] private float _steering;
    [SerializeField] private string _nitro;
    [SerializeField] private int _level;
    [SerializeField] private int _max_speed;
}