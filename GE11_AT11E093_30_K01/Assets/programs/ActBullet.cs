using System.Collections;
using UnityEngine;

public class ActBullet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(DestroySeconds(3.0f));
    }
    IEnumerator DestroySeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        DestroyBullet();
    }

    private void DestroyBullet()
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Breakable"))
        {
            Destroy(collision.gameObject);
            DestroyBullet();
        }
        else
        {
            DestroyBullet();
        }
    }
}
