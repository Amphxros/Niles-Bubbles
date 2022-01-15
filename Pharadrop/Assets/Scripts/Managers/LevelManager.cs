using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private static System.Random random= new System.Random();
    public GameObject[] balls;

    public int balls_per_row;
    public int num_of_cols;
    void Start()
    {
        createLevel();
    }
    public void createLevel(){
        
        for(int i=0;i<balls_per_row; i++){
            for(int j=0;j<num_of_cols; j++){
                int r= random.Next(0,balls.Length);
                 Instantiate(balls[0], transform.position + new Vector3(i + j%2,j,0), transform.rotation); //instanciamos el objeto

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
