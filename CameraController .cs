using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float rotateSpeed = 100f;
    public float zoomSpeed = 10f;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float h = rotateSpeed * Input.GetAxis("Mouse X") * Time.deltaTime;
            float v = rotateSpeed * Input.GetAxis("Mouse Y") * Time.deltaTime;

            transform.RotateAround(Vector3.zero, Vector3.up, h);
            transform.RotateAround(Vector3.zero, transform.right, -v);
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        transform.position += transform.forward * scroll * zoomSpeed;
    }
}