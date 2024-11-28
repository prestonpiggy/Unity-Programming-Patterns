using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slate : MonoBehaviour
{
    //
    private Renderer renderer_;

    private void Awake()
    {
        renderer_ = GetComponent<Renderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetDead()
    {
        renderer_.material.color = Color.black;
    }
    public void SetAlive() 
    {
        renderer_.material.color = Color.white;
    }
}
