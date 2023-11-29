using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; 
    public Vector3 offset;
    public float rotationSpeed = 0.1f;

    private float currentRotationAngle;

    void LateUpdate()
    {
     
        if (Input.GetMouseButton(2))
        {
            currentRotationAngle += Input.GetAxis("Mouse X") * rotationSpeed;
            Quaternion rotation = Quaternion.Euler(0, currentRotationAngle, 0);
            offset = rotation * offset;
        }

        transform.position = player.position + offset;

        transform.LookAt(player.position);
    }
}
