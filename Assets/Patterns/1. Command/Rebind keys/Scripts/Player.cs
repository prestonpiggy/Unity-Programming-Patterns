using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{   
    
    public int CoinAmount = 0;
    public int EnemiesKilled = 0;
    // event for coin collection
    public event Action CoinCollectedEvent;
    public event Action EnemyKilledEvent;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void AddCoin()
    {
        CoinAmount++;
        CoinCollectedEvent.Invoke();
    }
    public void KillEnemy()
    {
        EnemiesKilled++;
        EnemyKilledEvent.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);

        }
    }
}
