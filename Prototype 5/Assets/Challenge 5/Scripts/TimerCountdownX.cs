using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerCountdownX : MonoBehaviour
{
    private TextMeshProUGUI timerText;
    public int secondsLeft = 30;
    public bool takingAway = false;
    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();

        timerText.text = secondsLeft + "s";
    }
    void Update()
    {
        if(takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
    }
    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        timerText.text = "Time: " + secondsLeft + "s";
        takingAway = false;
    }

}
