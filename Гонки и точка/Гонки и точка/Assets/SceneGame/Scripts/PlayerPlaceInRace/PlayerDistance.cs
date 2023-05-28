using UnityEngine;

public class PlayerDistance : MonoBehaviour
{
    /*[HideInInspector]*/ public int WaypointNumber;
    /*[HideInInspector]*/ public int LapNumber;
    /*[HideInInspector]*/ public float DistanceCurrentWaypoint;

    private Checkpoints _checkpoints;
    private Transform _player;

    private void Start()
    {
        _checkpoints = Checkpoints.Instance;
        _player = SelectCar.Instance.gameObject.transform;
    }

    private void Update()
    {
        WaypointNumber= _checkpoints.CurrentWaypoint;
        LapNumber = _checkpoints.Lap - 1;

        Vector3 position_waypoint = new Vector3(_checkpoints.CurrentCheckpoint().x, 0, _checkpoints.CurrentCheckpoint().z);
        Vector3 player_position = new Vector3(_player.position.x, 0, _player.position.z);
        DistanceCurrentWaypoint = Vector3.Distance(player_position, position_waypoint);
    }
}