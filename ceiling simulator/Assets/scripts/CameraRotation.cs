using UnityEngine;
using UnityEngine.InputSystem;

public class CameraRotation : MonoBehaviour
{
    public float sensitivity = 2.0f; // Adjust the sensitivity of camera rotation
    public float minXRotation = -90.0f; // Minimum X rotation angle
    public float maxXRotation = 90.0f; // Maximum X rotation angle

    private float rotationX = 0.0f;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        // Get the mouse input from the Input System
        Vector2 mouseDelta = Mouse.current.delta.ReadValue();

        // Calculate rotation based on sensitivity
        rotationX -= mouseDelta.y * sensitivity * 0.1f;
        rotationX = Mathf.Clamp(rotationX, minXRotation, maxXRotation); // Clamp the rotation angle

        // Rotate the camera horizontally
        transform.localRotation = Quaternion.Euler(rotationX, 0, 0);

        // Rotate the whole GameObject (camera + parent if any) horizontally
        transform.parent.Rotate(Vector3.up * mouseDelta.x * sensitivity * 0.1f);
    }
}
