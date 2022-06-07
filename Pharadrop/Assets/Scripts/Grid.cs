using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    
    public BossUI bossUI;
    public TimeUI timeUI;
    public MovesUI movesUI;

    public UIManager ui_manager;

    List <GameObject> currGrid;
    
    Vector3 initPosition;
    public GameObject[] balls;
    private GameObject[,] grid;
    private int ROWS=5;
    private int COLS=5;
    
    public FileManager manager;
    void Start()
    {
        
       build();
    }

    void build(){

        string [] level= manager.getData();
        ROWS= 20;
        COLS= 20;
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
                float x=-1;

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

                grid[i,j]=g;
               
               
                AttachToGridOnTrigger a= g.AddComponent<AttachToGridOnTrigger>();
                a.setGrid(this);
                
                BallID b= g.GetComponent<BallID>();

                b.indX=i;
                b.indY=j;

                g=null;
            }
        }
    }

    void Update()
    {
        
    }

    public void checkDestroyable(GameObject g,int i, int j){

    }

    public void attachBall(GameObject g,int i, int j){
        
        switch(manager.getTypeOfLevel()){
            case LevelType.BOSS:
            bossUI.SetBossHP(bossUI.getBossHP() - 10);
            break;

            case LevelType.TIME:
            break;

            case LevelType.MOVES:
            movesUI.OnShoot();
            break;
        }


        print(i + " "+ j);
        g.transform.parent= transform;
        g.transform.position= new Vector3(-4,4,0);
        BallID b= g.GetComponent<BallID>();
        b.indX=i;
        b.indY=j;
        if(i%2==0){
            g.transform.position+=new Vector3(j,-i,0);
        }
        else{
             g.transform.position+=new Vector3(j + 0.5f,-i,0);
        }

        grid[i,j]=g;
      
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
