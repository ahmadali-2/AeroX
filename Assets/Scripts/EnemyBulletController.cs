using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletController : MonoBehaviour
{
    public Transform enemyBullet;
    public GameObject explosion;
    private float _bulletSpeed = 0.3f;
    void Start()
    {
        
    }
    void Update()
    {
        enemyBullet.transform.position = new Vector2(transform.position.x, transform.position.y - _bulletSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Jet(Clone)")
        {
            Destroy(collision.gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);
        }
    }
}
