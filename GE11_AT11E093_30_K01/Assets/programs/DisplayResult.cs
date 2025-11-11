using UnityEngine;
using UnityEngine.UI;

public class DisplayResult : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float t = CountTime.elapsedTime;

        string timeMessage = "TIME SCORE : " + t.ToString("0.00");

        GetComponent<Text>().text = timeMessage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
