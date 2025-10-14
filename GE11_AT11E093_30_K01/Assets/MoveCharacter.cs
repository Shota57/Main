using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    Rigidbody rb;
    Vector3 moveForward;
    float speed = 15.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        moveForward = new Vector3(0.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(moveForward * speed);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            moveForward.x = 1.0f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveForward.x = -1.0f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveForward.y = -1.0f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            moveForward.y = 1.0f;
        }
    }
}
