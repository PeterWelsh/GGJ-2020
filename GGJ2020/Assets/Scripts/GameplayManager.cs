using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour
{
    float startTime;
    public Text timeText;
    float totalTime = 300.0f;

    // Start is called before the first frame update
    void Start()
    {
        startTime = totalTime;
    }

    // Update is called once per frame
    void Update()
    {
        totalTime -= Time.deltaTime;
        string minutes = (((int)totalTime) / 60).ToString("00");
        string seconds = (totalTime % 60).ToString("00");

        timeText.text = ("<TIME LEFT: " + minutes + ":" + seconds + ">");
    }
}
