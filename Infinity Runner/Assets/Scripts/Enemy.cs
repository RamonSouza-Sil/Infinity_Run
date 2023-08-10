using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speedEnemy;

    private Transform backPoint;

    private Animator anim;
    private Rigidbody2D rig;
    void Start()
    {
        backPoint = GameObject.Find("BackPoint").GetComponent<Transform>();

        anim = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector2.left * speedEnemy * Time.deltaTime);
        rig.velocity = new Vector2(-speedEnemy, rig.velocity.y);
        if (transform.position.x < backPoint.position.x)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            anim.SetTrigger("Destroy");
            Destroy(gameObject, 1f);
        }
    }
}
