using UnityEngine;

public class BotDistance : MonoBehaviour
{
    /*[HideInInspector]*/ public int WaypointNumber;
    /*[HideInInspector]*/ public int LapNumber;
    /*[HideInInspector]*/ public float DistanceCurrentWaypoint;

    [SerializeField] private RCC_AICarController _car;

    private void Update()
    {
        WaypointNumber = _car.currentWaypoint;
        LapNumber = _car.lap;
        var waypoints = _car.waypointsContainer.waypoints;

        Vector3 position_waypoint = new Vector3(waypoints[WaypointNumber].transform.position.x, 0,
            waypoints[WaypointNumber].transform.position.z);
        Vector3 bot_position = new Vector3(gameObject.transform.position.x, 0,
            gameObject.transform.position.z);
        DistanceCurrentWaypoint = Vector3.Distance(bot_position, position_waypoint);
    }
}