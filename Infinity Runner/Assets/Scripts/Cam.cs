using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public float speedCam;

    private GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    
    void Update()
    {
        //movimenta o a camera presa no Player para frente
        Vector3 newPosition = new Vector3(player.transform.position.x + 2f, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, newPosition, speedCam * Time.deltaTime );
    }
}
