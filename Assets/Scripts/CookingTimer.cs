using UnityEngine;
using TMPro;

public class CookingTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float timeRemaining = 120f; // 2 minutes
    private bool timerRunning = false;

    public void StartTimer()
    {
        timerRunning = true;
    }

    public void StopTimer()
    {
        timerRunning = false;
    }

    public void ResetTimer()
    {
        timeRemaining = 120f;
        timerRunning = false;
        UpdateTimerDisplay();
    }

    void Update()
    {
        if (timerRunning && timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerDisplay();
        }
        else if (timeRemaining <= 0)
        {
            timerRunning = false;
            timerText.text = "Done!";
        }
    }

    private void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}