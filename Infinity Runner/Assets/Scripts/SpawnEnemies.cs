using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public float initialTime;
    public float minTime, maxTime;


    public List<GameObject> EnemieList = new List<GameObject>();

    void Start()
    {
        
    }

    private float timeControl;
    void Update()
    {
        timeControl += Time.deltaTime;
        if (timeControl >= initialTime)
        {
            Instantiate(EnemieList[Random.Range(0, EnemieList.Count)], transform.position  + new Vector3(0, Random.Range(-2,3), 0), transform.rotation);

            initialTime = Random.Range(minTime, maxTime);
            timeControl = 0;
        }
    }
}
