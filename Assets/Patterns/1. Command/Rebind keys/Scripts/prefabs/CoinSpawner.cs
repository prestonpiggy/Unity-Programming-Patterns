using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coin;
    //public int NumberOfCoins = 50;


    public float timeInterval = 1.1f;
    public float currentime = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        //for (int i = 0; i < NumberOfCoins; i++)
        //{
        Instantiate(coin, new Vector3(Random.Range(-10, 10), 0.3f, Random.Range(-10, 10)), coin.transform.rotation);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        currentime = currentime + Time.deltaTime;
        if (currentime > timeInterval)
        {
            currentime = 0;
            Instantiate(coin, new Vector3(Random.Range(-10, 10), 0.3f, Random.Range(-10, 10)), coin.transform.rotation);
        }
        
    }
}
