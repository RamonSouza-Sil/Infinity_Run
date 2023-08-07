using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;
    public float ForcaPulo;

    public bool isJumping;// se estar pulando
    private Rigidbody2D rig;

    public GameObject Smoke;
    public GameObject Bullet;
    public Transform firePoint;
    void Start()
    {
        rig= GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        //movimenta o Persoangem para frente sempre.
        rig.velocity = new Vector2( Speed * Time.deltaTime, rig.velocity.y);

        //              Pula            se   isJumping for falso
        if (Input.GetKeyDown(KeyCode.W) && isJumping == false)
        {
            rig.AddForce(Vector2.up * ForcaPulo, ForceMode2D.Impulse);
            isJumping = true;

            Smoke.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(Bullet, firePoint.transform.position, firePoint.transform.rotation);
        }
    }

    // verifica se estar tocando o chão(Layer 9)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            isJumping = false;
            Smoke.SetActive(false);
        }
    }
}
