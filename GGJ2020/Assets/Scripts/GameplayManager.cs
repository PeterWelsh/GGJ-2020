using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour
{
    float startTime;
    float fraction = 0.0f;
    float posChange;
    public float totalTime;
    public Text timeText;
    public float waveSpeed = 0.5f;

    public GameObject waterPlane;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startTime = totalTime;
        startPos = waterPlane.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        totalTime -= Time.deltaTime;
        string minutes = (((int)totalTime) / 60).ToString("00");
        string seconds = (totalTime % 60).ToString("00");

        timeText.text = ("<TIME LEFT: " + minutes + ":" + seconds + ">");

        fraction += Time.deltaTime * waveSpeed;
        float os = Mathf.Cos(fraction / Mathf.PI) * 0.1f;
        waterPlane.transform.position = new Vector3(startPos.x, startPos.y + os, startPos.z);
    }
}
