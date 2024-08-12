using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    [SerializeField] private float totalTime = 60f; // Set your initial countdown time here
    [SerializeField] private TMP_Text displayText;
    [SerializeField] private GameObject gameOverBox;

    private void Start()
    {
        Time.timeScale = 1;
    }
    void Update()
    {
        totalTime -= Time.deltaTime; // Subtract the elapsed time from the total time

        if (totalTime <= 0f)
        {
            displayText.text = "Game Over";
            gameOverBox.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            displayText.text = Mathf.Round(totalTime).ToString() + "s";
        }
    }
}
