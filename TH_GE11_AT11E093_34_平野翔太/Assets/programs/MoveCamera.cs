using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    Vector3 cameraVec;
    GameObject playerObj;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cameraVec = new Vector3 (0.0f, 0.0f, 0.0f);
        playerObj = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        cameraVec.x = playerObj.transform.position.x;
        cameraVec.y = playerObj.transform.position.y + 1.0f;
        cameraVec.z = -5.0f;
        transform.position = cameraVec;

        transform.LookAt(playerObj.transform.position);
    }
}
