using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
  


    // Array to store the child GameObjects
    public GameObject[] childObjects;

    private void Start()
    {
        // Call the method to populate the array with children
        PopulateChildArray();

        // Now you can work with the childObjects array
        foreach (GameObject child in childObjects)
        {
            // Do something with each child GameObject
        }
    }

    private void PopulateChildArray()
    {
        // Get all child GameObjects (including inactive ones)
        Transform[] childTransforms = GetComponentsInChildren<Transform>(true);

        // Initialize the array
        childObjects = new GameObject[childTransforms.Length - 1]; // Subtract 1 to exclude the parent itself

        int index = 0;

        // Loop through the child transforms
        foreach (Transform childTransform in childTransforms)
        {
            if (childTransform.gameObject != this.gameObject)
            {
                // Add the child GameObject to the array
                childObjects[index] = childTransform.gameObject;
                index++;
            }
        }
    }

    private void Update()
    {
        childObjects[1].SetActive(childObjects[0].GetComponent<Timer>().conditionToCount);
    }

}


