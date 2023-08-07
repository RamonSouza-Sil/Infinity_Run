using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speedBullet;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector2.right * speedBullet * Time.deltaTime);
    }
}
