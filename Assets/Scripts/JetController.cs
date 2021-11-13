using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class JetController : MonoBehaviour
{
    public GameObject explode;
    Rigidbody2D rigidBody2d;
    public Transform bulletSegment;
    public Transform rocketSegment;
    float x = 0;
    float y = -7;
    float speed = 0.2f;
    float bulletSpeed = 2f;
    void Start()
    {
        rigidBody2d = GetComponent<Rigidbody2D>();
        x = rigidBody2d.position.x;
        y = rigidBody2d.position.y;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(bulletSegment, new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y + bulletSpeed), Quaternion.identity);
        }
        if (Input.GetKey(KeyCode.R))
        {
            Instantiate(rocketSegment, new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y + bulletSpeed), Quaternion.identity);
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            y += speed;
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            y -= speed;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            x -= speed;
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            x += speed;
        }
    }
    private void FixedUpdate()
    {
        rigidBody2d.position = new Vector2(x, y);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Enemy0"))
        {
            Instantiate(explode, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}

