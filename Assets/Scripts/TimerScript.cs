using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{

    [SerializeField]
    float CountdownFrom;
    [SerializeField]
    Text CountdownText;


    void Start()
    {
        if (CountdownText == null)
        {
            Debug.LogError("STATUS INDICATOR: No text object referenced!");
        }
    }
    void Update()
    {
        float time = CountdownFrom - Time.timeSinceLevelLoad;
        CountdownText.text = "TIME LEFT: " + time.ToString("0") + "s";

        if (time <= 0f)
        {
            TimeUp();
        }
    }

    void TimeUp()
    {
        SceneManager.LoadScene(2);
    }
}