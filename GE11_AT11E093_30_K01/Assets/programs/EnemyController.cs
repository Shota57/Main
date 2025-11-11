using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // ジャンプ力を定義する変数「addJump」を設定
    // 型はfloatにする
    public float addJump = 5.0f;

    // 接触判定を取る
    private void OnCollisionEnter(Collision collision)
    {
        // 接触して得られた変数 collision 内の gameObject の name が「Player」なら
        if (collision.gameObject.name == "Player")
        {
            // Enemy の Collider（当たり判定）を GetComponent で取得する
            Collider enemyCollider = GetComponent<Collider>();

            // OnCollisionEnter の変数 collision で取得した Player の collider（当たり判定）を変数に入れる
            Collider playerCollider = collision.collider;

            // GetComponent で変数 collision 内の gameObject から Rigidbody を取得する
            // 踏んだ時にジャンプさせる力を加える用途
            Rigidbody playerRb = collision.gameObject.GetComponent<Rigidbody>();

            // 敵の中心座標より、Player（collision）の底面座標が高ければ踏めた判定にする
            if (playerCollider.bounds.min.y > enemyCollider.bounds.center.y)
            {
                // 自身を削除
                Destroy(gameObject);

                // AddForce でプレイヤーの Rigidbody に上向きの力を加えて、
                // 踏みつけた後の反動を実現する
                playerRb.AddForce(Vector3.up * addJump, ForceMode.Impulse);
            }
            else
            {
                // 変数 collision 内にアタッチされている MoveCharacter スクリプトを GetComponent で取り出す
                collision.gameObject.GetComponent<MoveCharacter>().Respawn();
            }
        }
    }
}
