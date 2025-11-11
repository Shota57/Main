using UnityEngine;
using UnityEngine.UI;

public class CountTime : MonoBehaviour
{
    float startTime;
    public static float elapsedTime;
    Text tx;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startTime = Time.time;
        elapsedTime = 0.0f;
        tx = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime = Time.time - startTime;
        tx.text = elapsedTime.ToString("0.00");
    }
}
