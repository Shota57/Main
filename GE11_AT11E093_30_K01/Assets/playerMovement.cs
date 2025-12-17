using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController characterController;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float sidespeed = Input.GetAxis("Horizontal") * speed;
        float forwardspeed = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(sidespeed, 0, forwardspeed) * Time.deltaTime;
        movement = transform.rotation * movement;

        characterController.Move(movement);
    }
}
