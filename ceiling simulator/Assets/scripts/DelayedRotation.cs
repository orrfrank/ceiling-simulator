using UnityEngine;

public class DelayedRotation : MonoBehaviour
{
    public Transform parentTransform; // Reference to the parent object's transform
    public float rotationSpeed = 30.0f; // Adjust this value to control the speed of rotation

    private float currentRotationTime = 0.0f;
    private Quaternion initialRotation;
    private Quaternion targetRotation;

    void Start()
    {
        // Store the initial rotation of the child object
        initialRotation = transform.localRotation;
    }

    void Update()
    {
        // Calculate the target rotation based on the parent's rotation
        targetRotation = parentTransform.rotation * initialRotation;

        // Apply a delay by lerping between the current rotation and the target rotation
        currentRotationTime += Time.deltaTime;
        float t = currentRotationTime * rotationSpeed;

        // You can adjust the lerp method (e.g., Lerp, Slerp) for different rotation effects
        transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, t);
    }
}
