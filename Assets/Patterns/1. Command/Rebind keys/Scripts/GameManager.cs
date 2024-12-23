using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public enum GameState
{
    MENU = 100,
    PLAYING = 101,
    PAUSE = 102,
    GAME_OVER = 103,
    REPLAYING = 104

}
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    // Start is called before the first frame update

    

    public static GameState gamestate = GameState.MENU;

    public AudioSource baseMusic;
    public AudioSource battleMusic;
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
        //Switching state menu->play
        GameManager.gamestate = GameState.PLAYING;
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
     public void PLAYSOUND(AudioClip clip)
      {
        
    }
}
