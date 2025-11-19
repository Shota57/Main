using UnityEngine;

public class togeScript : MonoBehaviour
{
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
             collision.gameObject.GetComponent<MoveCharacter>().Respawn();
            
        }
    }
}
