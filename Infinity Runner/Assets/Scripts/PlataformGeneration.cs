using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformGeneration : MonoBehaviour
{
    public GameObject Platform;
    public Transform point;
    public float Distance;

    private float platWidth;
    void Start()
    {
        if (Platform.GetComponent<BoxCollider2D>())
        {
            platWidth = Platform.GetComponent<BoxCollider2D>().size.x;
        }
        else
        {
            platWidth = Platform.GetComponent<PolygonCollider2D>().bounds.size.x;
            //bounds - pega o tamanho do colisor do OBJ
        }
    }


    void Update()
    {
        if (transform.position.x < point.position.x)
        {
            Distance = Random.Range(2, 6);

            transform.position = new Vector3(transform.position.x + platWidth + Distance, transform.position.y, transform.position.x);

            Instantiate(Platform, transform.position, transform.rotation);
        }
    }
}
