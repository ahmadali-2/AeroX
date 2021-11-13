using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{


    public Transform jetSegment;
    public Transform enemySegment01;
    public Transform enemySegment02;
    public Transform enemySegment03;
    public Transform upWallSegment;
    public Transform downWallSegment;

    private float _x;
    private float _y;
    private float _spawnTime = 1.5f;
    private float _spawnDelay = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", _spawnTime, _spawnDelay);
        Instantiate(jetSegment, new Vector2(0, -7), Quaternion.identity);
        Instantiate(downWallSegment, new Vector2(0, -15), Quaternion.identity);
        Instantiate(upWallSegment, new Vector2(0, 10.5f), Quaternion.identity);
    }
    public void SpawnEnemy()
    {
        Transform enemy1 = Instantiate(this.enemySegment01);
        Transform enemy2 = Instantiate(this.enemySegment02);
        Transform enemy3 = Instantiate(this.enemySegment03);
        _x = Random.Range(-15, 15);
        _y = enemy1.position.y;
        enemy1.transform.position = new Vector2(
         _x, _y
        );
        _x = Random.Range(-15, 15);
        _y = enemy2.position.y;
        enemy2.transform.position = new Vector2(
         _x, _y
        );
        _x = Random.Range(-15, 15);
        _y = enemy3.position.y;
        enemy3.transform.position = new Vector2(
         _x, _y
        );
    }

}
