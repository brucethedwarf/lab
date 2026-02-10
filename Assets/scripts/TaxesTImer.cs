using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public float countdownTime = 300f; // Initial time in seconds
    public TextMeshProUGUI timerText; // Reference to a UI Text element

    private float currentTime;

    void Start()
    {
        currentTime = countdownTime;
    }

    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            // Use TimeSpan for easy formatting
            TimeSpan timeSpan = TimeSpan.FromSeconds(currentTime);
            timerText.text = timeSpan.ToString(@"mm\:ss");
        }
        else
        {
            currentTime = 0;
            timerText.text = "00:00";
            // Add game over logic here
        }
    }

    // This method is called by the UI Button's OnClick() event
    public void ResetTimer()
    {
        currentTime = countdownTime; // Reset the current time to the starting value
    }
}
