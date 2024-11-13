using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    float rotatespeed = 90f;
    public AudioSource coin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f,0f,rotatespeed*Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {

        //Debug.Log(other.gameObject.name + "hit");
        if (other.tag == "Player") 
        {
            //AudioSource.Instantiate(coin);
            other.GetComponent<Player>().AddCoin();
            Destroy(gameObject);
        }

        
        Destroy(gameObject);
    }
}
