using UnityEngine;
using UnityEngine.Jobs;

public class MoveCharacter : MonoBehaviour
{
    Rigidbody rb;
    Vector3 moveForward;
    public float speed = 1.0f;
    public KeyCode rightKey = KeyCode.D;
    public KeyCode leftKey = KeyCode.A;

    Vector3 jumpForward;
    public KeyCode jumpKey = KeyCode.Space;
    public float jumpPower = 6.5f;

    Vector3 playerPos; // プレイヤーの位置情報

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        moveForward = new Vector3(0.0f, 0.0f, 0.0f);
        jumpForward = new Vector3(0.0f, 1.0f, 0.0f);

        playerPos = transform.position + new Vector3(0.0f, 0.5f, 0.0f); // プレイヤーの位置情報を取得
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(moveForward * speed, ForceMode.Impulse);
    }
    public void Respawn()
    {
        GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        transform.position = playerPos;
        transform.rotation = Quaternion.Euler(0, 90, 0);
    }
    public void tpHit()
    {
        GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        transform.position = new Vector3(-12.0f, 62.0f,0.0f);
        transform.rotation = Quaternion.Euler(0, 90, 0);
    }
    public void checkPoint()
    {
        GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        transform.position = transform.position + new Vector3(0.0f, 2.5f, 0.0f);
        transform.rotation = Quaternion.Euler(0, 90, 0);
        playerPos = transform.position;
    }
    void Update()
    {
        Vector3 center = transform.position + Vector3.down * 0.41f;
        float radius = 0.1f;
        LayerMask layer = LayerMask.GetMask("Ground");
        bool isGround = Physics.CheckSphere(center, radius, layer);
        Debug.Log(isGround);

        if (isGround && Input.GetKeyDown(jumpKey))
        {
            rb.AddForce(jumpForward * jumpPower, ForceMode.Impulse);
        }
        if (transform.position.y < -5)
        {
            Respawn();
        }
        if (Input.GetKey(rightKey))
        {
            moveForward.x = 1.0f;
            transform.localEulerAngles = new Vector3(0, 90, 0);
        }
        else if (Input.GetKey(leftKey))
        {
            moveForward.x = -1.0f;
            transform.localEulerAngles = new Vector3(0, -90, 0);
        }
        else
        {
            moveForward.x = 0.0f;
        }
    }
}

