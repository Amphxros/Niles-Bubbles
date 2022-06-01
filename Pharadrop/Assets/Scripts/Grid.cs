using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    Vector3 initPosition= new Vector3(-5,3,0);
    private GameObject[,] balls;
    public int ROWS=5;
    public int COLS=5;


    public Vector3 init(){return initPosition;}
    void Start()
    {
        balls= new GameObject[ROWS, COLS];

        for(int i=0; i<ROWS; i++){
            for(int j=0; j<COLS; j++){
                balls[i,j]=null;
            }
        }
    }

    void Update()
    {
        
    }

    public void attachBall(GameObject g,int i, int j){
        balls[i,j]=g;
        balls[i,j].transform.position= new Vector3(initPosition.x + i + i%2*(0.5f), initPosition.y+j, 0);
        BallMovement b= g.GetComponent<BallMovement>();
        b.Desactivate();
    }

    public void detachBall(int i, int j){
       GameObject g= balls[i,j];
       Destroy(g);
       balls[i,j]=null;


    }

    public List<GameObject> getNeightbours(int i, int j){
        List<GameObject> obj= new List<GameObject>();

        if(i>0){
            obj.Add(balls[i-1,j]);
            if(j>0){
                obj.Add(balls[i-1,j-1]);
            }
            if(j<ROWS-1){
                obj.Add(balls[i-1,j+1]);
            }
        }
        if(j>0){
            obj.Add(balls[i,j-1]);
             if(i>0){
                obj.Add(balls[i-1,j-1]);
            }
            if(i<COLS-1){
                obj.Add(balls[i+1,j-1]);
            }

        }
        if(i<COLS){
            obj.Add(balls[i+1,j]);
            if(j>0){
                obj.Add(balls[i+1,j-1]);
            }
            if(j<ROWS-1){
                obj.Add(balls[i+1,j+1]);
            }
        }
        if(j<ROWS){
             obj.Add(balls[i,j+1]);
              if(i>0){
                obj.Add(balls[i-1,j+1]);
            }
            if(i<COLS-1){
                obj.Add(balls[i+1,j+1]);
            }

        }

        return obj;

    }
}
