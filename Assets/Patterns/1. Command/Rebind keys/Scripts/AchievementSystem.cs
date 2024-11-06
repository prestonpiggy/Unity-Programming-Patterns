using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementSystem : MonoBehaviour
{
    public Player checkstats;
    public GameObject Player;
    private bool CoinAchievement = false;
    int currentcoins = 0;  
    int numberCoinsNeeded = 5;
    private bool KillAchievement = false;
    int currentKills = 0;
    int numberKillsNeeded = 5;
    //boolean enum + per achievement.
    //false, 10 coin colleted , "you just collected 10"

    // Start is called before the first frame update
    void Start()
    {
        Player.GetComponent<Player>().CoinCollectedEvent += OnCoinCollected;
        Player.GetComponent<Player>().EnemyKilledEvent += OnEnemykilled;
    }

    // Update is called once per frame
    void Update()
    {   
        
        
    }
    public void OnCoinCollected()
    {
        currentcoins = checkstats.CoinAmount;
        if (currentcoins == numberCoinsNeeded)
        {
            CoinAchievement = true;
            Debug.Log("Coincollector achiement unlocked!!");
        }
        Debug.Log("coin collected you own: "+ currentcoins + "coins.");
        
        //  todo: - check mow many coins player has
        //       -check if the achievment is unlocked
        //       -unlock if enough
    }
    public void OnEnemykilled()
    {
        currentKills = checkstats.EnemiesKilled;
        if (currentKills == numberKillsNeeded)
        {
            KillAchievement = true;
            Debug.Log("Terminator achiement unlocked!!");
        }
        Debug.Log("enemy was killed, killcount is:" + currentKills + ".");
        
    }
}
