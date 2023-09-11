using UnityEngine;

public class RotationChecker : MonoBehaviour
{

    public static float GetXRotation(GameObject obj)
    {
        // Ensure the GameObject is not null
        if (obj != null)
        {
            // Get the Euler angles of the GameObject's rotation
            Vector3 rotation = obj.transform.eulerAngles;

            // Return the X rotation component
            return rotation.x;
        }
        else
        {
            // Handle the case where the GameObject is null
            Debug.LogWarning("The GameObject is null.");
            return 0.0f; // Return a default value (0.0) or handle the error as needed
        }

       
    }

    
}
