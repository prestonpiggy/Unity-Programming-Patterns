using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameoflife : MonoBehaviour
{

    //[Range(10,100)]
    public static int width = 20;
    //[Range(10, 100)]
    public static int height = 20;

    private float dist = 1.0f;

    public GameObject MySlate;

    //2d array of slateshaving                 x    y
    private Slate[,] all_slates = new Slate[width,height];
    //single buffer
    private bool[,] grid = new bool[width,height];

    // Start is called before the first frame update
    void Start()
    {
        if (MySlate != null)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    all_slates[j,i] = Instantiate(MySlate, new Vector3(j*dist,0,i*dist), MySlate.transform.rotation).GetComponent<Slate>();
                    all_slates[j,i].SetDead();
                    // C# sets false by default but whatever
                    grid[j, i] = false;
                }
            }

        }
        ////set few alive
        //all_slates[5, 5].SetAlive();
        ////nearby
        //all_slates[4, 5].SetAlive();//-1,0  +1,0    0,+1    0,-1    -1,-1   +1,+1   -1,+1   +1,-1
        //all_slates[6, 5].SetAlive();
        //all_slates[5, 6].SetAlive();
        //all_slates[5, 4].SetAlive();
        //all_slates[4, 4].SetAlive();
        //all_slates[6, 6].SetAlive();
        //all_slates[4, 6].SetAlive();
        //all_slates[6, 4].SetAlive();

        grid[5,3] = true;
        grid[7, 5] = true;
        grid[2, 9] = true;
        grid[10, 2] = true;


    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0;i < height; i++)
        {
            for( int j = 0; j < width; j++)
            {
                if (grid[j, i] == true)
                {
                    all_slates[j,i].SetAlive();
                }
                else
                {
                    all_slates[j, i].SetDead();
                }
            }
        }
    }//make function to check 
}
