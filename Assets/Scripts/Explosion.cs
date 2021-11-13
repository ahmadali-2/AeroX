using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public Transform myJet;
    void Start()
    {
        Destroy(gameObject, 0.65f);
        Instantiate(myJet, new Vector2(0, -7), Quaternion.identity);
    }

}
