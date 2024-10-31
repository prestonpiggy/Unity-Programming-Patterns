using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coin;
    public int NumberOfCoins = 50;
    

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < NumberOfCoins; i++)
        {
            Instantiate(coin, new Vector3(Random.Range(-20, 20), 0.3f, Random.Range(-20, 20)), coin.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
