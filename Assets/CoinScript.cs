using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    float rotatespeed = 90f;
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
        other.GetComponent<Player>().AddCoin();
        Destroy(gameObject);
    }
}
