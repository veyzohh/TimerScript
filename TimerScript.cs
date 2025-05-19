using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;

public class TimerScript : UdonSharpBehaviour
{
    [Header("Timer Settings")]
    public float timerDuration = 30f; // seconds

    [Header("UI Elements")]
    public Text timerText;

    private float timeLeft;
    private bool timerRunning = false;

    void Start()
    {
        ResetTimer();
    }

    public void StartTimer()
    {
        timerRunning = true;
    }

    public void ResetTimer()
    {
        timeLeft = timerDuration;
        timerRunning = false;
        UpdateTimerDisplay();
    }

    void Update()
    {
        if (!timerRunning) return;

        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0f)
        {
            timeLeft = 0f;
            timerRunning = false;
            TimerFinished();
        }

        UpdateTimerDisplay();
    }

    void UpdateTimerDisplay()
    {
        if (timerText != null)
        {
            int minutes = Mathf.FloorToInt(timeLeft / 60f);
            int seconds = Mathf.FloorToInt(timeLeft % 60f);
            timerText.text = $"{minutes:00}:{seconds:00}";
        }
    }

    void TimerFinished()
    {
        Debug.Log("⏰ Timer finished!");
        // Add custom behavior here (e.g., trigger an animation, send an event, etc.)
    }
}
