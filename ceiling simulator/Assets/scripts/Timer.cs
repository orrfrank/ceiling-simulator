using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public GameObject objectToCheck;
    public GameObject notLooking;

    public float updateInterval = 1f; // Update interval in seconds
    public bool conditionToCount = true; // Set your condition here
    public bool startOnAwake = true; // Start the timer on Awake

    private float timer = 0;
    private TextMeshProUGUI textMesh;

    private void Awake()
    {
        textMesh = GetComponent<TextMeshProUGUI>();

        if (startOnAwake)
        {
            StartTimer();
        }
    }

    private void StartTimer()
    {
        InvokeRepeating("UpdateTimer", 0, updateInterval);
    }

    private void UpdateTimer()
    {
        if (conditionToCount)
        {
            timer += updateInterval;
            UpdateTimerText();
        }
    }

    private void UpdateTimerText()
    {
        // Format the timer value as an integer
        textMesh.text = Mathf.FloorToInt(timer).ToString();
    }

    private void Update()
    {
        Debug.Log(objectToCheck.transform.rotation.x);
        conditionToCount = objectToCheck.transform.rotation.x <= -0.45f;

        notLooking.SetActive(!conditionToCount);
    }
}
