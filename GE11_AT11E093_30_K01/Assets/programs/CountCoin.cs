using UnityEngine;

public class CountCoin : MonoBehaviour
{
    // coin を獲得した時に獲得できる Score
    // 変数名は coinScore にする。型名は int にする（小数点を使わないので）
    public int coinScore = 10;

    // OnTriggerEnter を使えたら使っても良い（そっちの方が自然になるので）
    private void OnCollisionEnter(Collision collision)
    {
        // もし collision 内に格納された gameObject の name が「Player」なら
        if (collision.gameObject.name == "Player")
        {
            // 名前が ScoreText のオブジェクトを取得
            GameObject coinCountObject = GameObject.Find("ScoreText");

            // GetComponent で CountScore スクリプトを取得する
            CountScore countScore = coinCountObject.GetComponent<CountScore>();

            // CountScore スクリプト内の AddScore 関数を呼び出す
            countScore.AddScore(coinScore);

            // このオブジェクトを削除する
            Destroy(gameObject);
        }
    }
}
