using UnityEngine;
using System.Collections;

public class CameraRotate : MonoBehaviour
{
    private float _speed_rotate = 0.25f;

    private void Start()
    {
        StartCoroutine(Rotate());
    }

    private IEnumerator Rotate()
    {
        yield return new WaitForSecondsRealtime(3);
        while (true)
        {
            gameObject.transform.Rotate(Vector2.up * _speed_rotate);
            yield return new WaitForEndOfFrame();
        }
    }
}