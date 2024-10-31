using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementSystem : MonoBehaviour
{
    public GameObject Player;
    //boolean enum + per achievement.
    //false, 10 coin colleted , "you just collected 10"

    // Start is called before the first frame update
    void Start()
    {
        Player.GetComponent<Player>().CoinCollectedEvent += OnCoinCollected;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCoinCollected()
    {
        Debug.Log("coin was callected");
        //  todo: - check mow many coins player has
        //       -check if the achievment is unlocked
        //       -unlock if enough
    }           
}
