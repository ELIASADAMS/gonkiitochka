using UnityEngine;

public class Arrow : MonoBehaviour
{
    private void LateUpdate()
    {
        Vector3 point = Checkpoints.Instance.CurrentCheckpoint();
        point = new Vector3(point.x, gameObject.transform.position.y, point.z);

        gameObject.transform.LookAt(point);
    }
}