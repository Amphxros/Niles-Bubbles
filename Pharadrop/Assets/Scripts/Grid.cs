using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    Vector3 initPosition;
    public GameObject[] balls;
    private GameObject[,] grid;
    public int ROWS=5;
    public int COLS=5;
    public Vector3 init(){return initPosition;}

    public FileManager manager;
    void Start()
    {
        initPosition= new Vector3(0,0,0);
       build();
    }

    void build(){

        string [] level= manager.getData();
        ROWS= 20;
        COLS= level[0].Split(' ').Length;
        grid= new GameObject[ROWS, COLS];

        for(int i=0; i<ROWS; i++){

            for(int j=0; j<COLS;j++){
                grid[i,j]=null;
            }
        }

        for(int i=0; i<level.Length; i++){

            string[] line= level[i].Split(' ');

            for(int j=0; j<line.Length; j++){
                
                GameObject g= null;
                float x= (float)(j + 0.5f*j*(i%2));

                if(i%2==0){
                    x=j +1.0f;
                }
                else{
                    x= j +0.5f;
                }


                switch(line[j]){
                    case "A":
               
                        g= Instantiate(balls[0], transform.position + new Vector3(x,i,0), Quaternion.identity, this.transform) as GameObject;
                    break;
                
                    case "B":
                    
                        g= Instantiate(balls[1], transform.position + new Vector3(x,i,0), Quaternion.identity, this.transform) as GameObject;
                    break;
                    case "C":
                        g= Instantiate(balls[2],  transform.position + new Vector3(x,i,0), Quaternion.identity, this.transform) as GameObject;
                    break;
                
                    case "D":
                    
                        g= Instantiate(balls[3],  transform.position + new Vector3(x,i,0), Quaternion.identity, this.transform) as GameObject;
                    break;
                    case "E":
                        g= Instantiate(balls[4],  transform.position + new Vector3(x,i,0), Quaternion.identity, this.transform) as GameObject;
                    break;
                
                    case "F":
                        g= Instantiate(balls[5],  transform.position + new Vector3(x,i,0), Quaternion.identity, this.transform) as GameObject;
                    break;
                }

                grid[i,j]=g;

                g=null;
            }
        }
    }

    void Update()
    {
        
    }

    public void attachBall(GameObject g,int i, int j){
       grid[i,j]=g;
       grid[i,j].transform.position= new Vector3(initPosition.x + i + i%2*(0.5f), initPosition.y+j, 0);
        BallMovement b= g.GetComponent<BallMovement>();
        b.Desactivate();
    }

    public void detachBall(int i, int j){
       GameObject g= grid[i,j];
       Destroy(g);
       grid[i,j]=null;


    }

    // public List<GameObject> getNeightbours(int i, int j){
    //  List<GameObject> res= new List<GameObject>();

    //  return res;
    // }

    
}
