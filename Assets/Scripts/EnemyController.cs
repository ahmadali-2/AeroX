using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject explode;
    public GameObject enemyBullet;
    private float _bulletSpawnDelay = 1.5f;
    void Start()
    {
        InvokeRepeating("FireBullet", Random.Range(1, 1.5f), _bulletSpawnDelay);
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Enemy0"))
        {
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.name == "RocketExplosion(Clone)")
        {
            Destroy(this.gameObject);
        }
    }

    public void FireBullet()
    {
        Transform bullet = Instantiate(enemyBullet.transform, transform) as Transform;
        bullet.transform.position = new Vector2(this.transform.position.x, this.transform.position.y);
    }
}
