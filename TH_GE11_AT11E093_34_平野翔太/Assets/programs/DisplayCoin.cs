using UnityEngine;
using UnityEngine.UI;

public class DisplayCoin : MonoBehaviour
{
    void Start()
    {
        float c = CountScore.score;

        string coinMessage = "COIN SCORE : " + c.ToString();

        GetComponent<Text>().text = coinMessage;
    }
}
