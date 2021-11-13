using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallUp : MonoBehaviour
{
    public GameObject rocketExplosion;
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "BulletRound(Clone)")
        {
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.name == "Rocket(Clone)")
        {
            Instantiate(rocketExplosion, collision.gameObject.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
    }
}
