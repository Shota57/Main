// UIの型「Text」を使う時に必要なカタログといえば……？
using UnityEngine.UI;
using UnityEngine;

public class CountScore : MonoBehaviour
{
    // スコアを定義する変数「score」をint型で作成
    public static int score;

    // コインのテキストを格納する変数「coinTx」をText型で作成
    Text coinTx;

    void Start()
    {
        // score の初期値を 0 に
        score = 0;

        // coinTx に GetComponent で Text を格納
        coinTx = GetComponent<Text>();
    }

    // Score を増加させるメソッド
    public void AddScore(int addedScore)
    {
        score += addedScore;

        // coinTx の text を「Score : （score を文字列変換したもの）」にする
        coinTx.text = "COIN : " + score.ToString();
    }
}
