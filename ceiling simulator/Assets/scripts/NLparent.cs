using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NLparent : MonoBehaviour
{
    public Transform playerCamera;

    private void Update()
    {
        transform.position = playerCamera.position;
        transform.rotation = Quaternion.Inverse(playerCamera.rotation);
    }
}
