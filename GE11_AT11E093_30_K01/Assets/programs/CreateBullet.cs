using UnityEngine;

public class CreateBullet : MonoBehaviour
{
    public KeyCode shotKey = KeyCode.Mouse0;
    public GameObject bulletPrefab;
    public float shotpower = 15.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(shotKey))
        {
            Vector3 pos = transform.position + transform.forward * 0.5f;

            GameObject obj = Instantiate(bulletPrefab, pos, Quaternion.identity);

            obj.GetComponent<Rigidbody>().AddForce(transform.forward * shotpower, ForceMode.Impulse);
        }
    }
}
