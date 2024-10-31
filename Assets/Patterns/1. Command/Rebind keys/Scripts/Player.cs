using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int CoinAmount = 0;
    // event for coin collection
    public event Action CoinCollectedEvent;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void AddCoin()
    {
        CoinAmount++;
        CoinCollectedEvent.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
