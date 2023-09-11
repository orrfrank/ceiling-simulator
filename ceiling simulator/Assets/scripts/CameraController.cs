using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float minX;
    public float maxX;

    public float Sensitivity;
    public Camera cam;

    float rotY = 0f;
    float rotX = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }


    void Update()
    {
        rotY += Input.GetAxis("Mouse X") * Sensitivity;
        rotX += Input.GetAxis("Mouse Y") * Sensitivity;

        rotX = Mathf.Clamp(rotX, minX, maxX);

        transform.localEulerAngles = new Vector3(0, rotY, 0);
    }
}
