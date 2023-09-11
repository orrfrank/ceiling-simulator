using UnityEngine;

public class NotLookingScript : MonoBehaviour
{
    public Transform cameraTransform;  // Reference to the camera's transform
    public float rotationSpeed = 5f;  // Speed of rotation
    public float distanceToCamera = 2f;  // Initial distance between the object and the camera

    private void Update()
    {
        // Calculate the desired position based on the camera's position and distanceToCamera
        Vector3 desiredPosition = cameraTransform.position - cameraTransform.forward * distanceToCamera;

        // Smoothly move the object towards the desired position
        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * rotationSpeed);

        // Rotate the object to face the camera
        transform.LookAt(cameraTransform);
    }
}
