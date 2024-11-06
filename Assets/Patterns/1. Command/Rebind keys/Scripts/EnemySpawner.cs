using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public int NumberOfCoins = 50;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < NumberOfCoins; i++)
        {
            Instantiate(enemy, new Vector3(Random.Range(-20, 20), 0.3f, Random.Range(-20, 20)), enemy.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
