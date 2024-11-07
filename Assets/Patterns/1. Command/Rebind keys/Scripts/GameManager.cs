using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    // Start is called before the first frame update


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            Debug.Log("instance done");
            //dont destroy
            DontDestroyOnLoad(this);
        }
        else
        {
            Debug.Log("instance exists");
            Destroy(this);
            //Destroy(gameObject);
        }
    }
    public static void Startgame()
    {
        //SceneManager.LoadScene(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    public static void Destroygame()
    {
        Application.Quit();  
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
