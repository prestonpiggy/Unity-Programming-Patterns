using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{    public static AudioManager AudioManagerer { get; private set; }



    private void Awake()
    {
        if (AudioManagerer == null)
        {
            AudioManagerer = this;
            Debug.Log("audio done");
            //dont destroy
            DontDestroyOnLoad(this);
        }
        else
        {
            Debug.Log("instance exists");
            Destroy(this);
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlaySound() { 

    }

}
