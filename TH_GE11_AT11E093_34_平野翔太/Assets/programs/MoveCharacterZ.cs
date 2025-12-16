using UnityEngine;

public class MoveCharacterZ : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 15.0f;

    Vector3 jumpForward;
    public KeyCode jumpKey = KeyCode.Space;
    public float jumpPower = 6.5f;

    Vector3 playerPos;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        jumpForward = new Vector3(0.0f, 1.0f, 0.0f);

        playerPos = transform.position + new Vector3(0.0f, 0.5f, 0.0f);
    }


    void Update()
    {
        Vector3 moveDirection = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            0,
            Input.GetAxisRaw("Vertical")
            );

        float currentVelocityY = rb.linearVelocity.y;
        Vector3 velocity = moveDirection * speed;
        velocity.y = currentVelocityY;
        if (moveDirection != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveDirection);
            rb.linearDamping = 0.0f;
        }
        rb.linearVelocity = velocity;
        Vector3 center = transform.position + Vector3.down * 0.41f;
        float radius = 0.2f;
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
    }

    public void Respawn()
    {
        GetComponent<Rigidbody>().linearVelocity = Vector3.zero;

        transform.position = playerPos;
    }
}
