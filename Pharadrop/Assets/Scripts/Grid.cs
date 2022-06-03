using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{

    List<GameObject> visited;



    Vector3 initPosition;
    public GameObject[] balls;
    private GameObject[,] grid;
    private int ROWS=5;
    private int COLS=5;
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
        grid= new GameObject[COLS,ROWS];

        for(int i=0; i<COLS; i++){

            for(int j=0; j<ROWS;j++){
                grid[i,j]=null;
            }
        }

        for(int i=0; i<level.Length; i++){

            string[] line= level[i].Split(' ');

            for(int j=0; j<line.Length; j++){
                
                GameObject g= null;
                float x= (float)(j + 0.5f*j*(i%2));

                if(i%2==0){
                    x=j;
                }
                else{
                    x= j +0.5f;
                }


                switch(line[j]){
                    case "A":
               
                        g= Instantiate(balls[0], transform.position + new Vector3(x,-i,0), Quaternion.identity, this.transform) as GameObject;
                    break;
                
                    case "B":
                    
                        g= Instantiate(balls[1], transform.position + new Vector3(x,-i,0), Quaternion.identity, this.transform) as GameObject;
                    break;
                    case "C":
                        g= Instantiate(balls[2],  transform.position + new Vector3(x,-i,0), Quaternion.identity, this.transform) as GameObject;
                    break;
                
                    case "D":
                    
                        g= Instantiate(balls[3],  transform.position + new Vector3(x,-i,0), Quaternion.identity, this.transform) as GameObject;
                    break;
                    case "E":
                        g= Instantiate(balls[4],  transform.position + new Vector3(x,-i,0), Quaternion.identity, this.transform) as GameObject;
                    break;
                
                    case "F":
                        g= Instantiate(balls[5],  transform.position + new Vector3(x,-i,0), Quaternion.identity, this.transform) as GameObject;
                    break;
                }

                AttachToGridOnTrigger a= g.AddComponent<AttachToGridOnTrigger>();
                a.setGrid(this);
                
                BallID b= g.GetComponent<BallID>();

                grid[i,j]=g;
                b.indX=i;
                b.indY=j;

                g=null;
            }
        }
    }

    void Update()
    {
        
    }

    public void attachBall(GameObject g,int i, int j){
        
        g.transform.parent= this.gameObject.transform;
        float x=-1;
        if(i%2==0){
            x=j;
        }
        else{
            x= j +0.5f;
        }

         print(i + " "+ j);
        grid[i,j]=g;
        BallID b= g.GetComponent<BallID>();
        b.indX=i;
        b.indY=j;

       g.transform.position= this.transform.position + new Vector3(x, j, 0);

    }

    public void detachBall(int i, int j){
       GameObject g= grid[i,j];
       Destroy(g);
       grid[i,j]=null;


    }

   public List<GameObject> getNeightbours(int i, int j){
       List<GameObject> result= new List<GameObject>();
       if(i==0){
           if(j==0){
               result.Add(grid[i+1,j]);
               result.Add(grid[i,j-1]);
           }
           else{
               result.Add(grid[i+1,j]);
               result.Add(grid[i,j-1]);
               result.Add(grid[i-1,j]);
               result.Add(grid[i-1,j-1]);
           }
       }
       else if(i==grid.GetLength(0)){
           if(j==0){
               result.Add(grid[i-1,j]);
               result.Add(grid[i,j-1]);
           }
           else{
                result.Add(grid[i+1,j]);
                result.Add(grid[i,j-1]);
                result.Add(grid[i-1,j-1]);
           }
       }
       else{
               result.Add(grid[i+1,j]);
               result.Add(grid[i-1,j]);
               result.Add(grid[i,j-1]);
               result.Add(grid[i,j+1]);
               result.Add(grid[i+1,j-1]);
               result.Add(grid[i+1,j+1]);                
       }
       return result;
   }

    
}
