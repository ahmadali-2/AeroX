using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    float bulletSpeed = 0.2f;
    public GameObject enExplode;
    private void FixedUpdate()
    {
        this.transform.position = new Vector2(this.transform.position.x, this.transform.position.y + bulletSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Enemy0"))
        {
            Instantiate(enExplode, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(this.transform.gameObject);
        }
     
    }
}
