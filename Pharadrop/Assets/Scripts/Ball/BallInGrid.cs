using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BallID{blue, red, yellow,green, pink}
public enum BallState{Spawned, Launched, OnGrid, Destroy, HasToFall}
public class BallInGrid : MonoBehaviour
{
    public BallID mID;
    private BallState mState;


    private int row_;
    public int getRow(){
        return row_;
    }
    public void setRow(int row){row_=row;}
    
    
    private int col_;
    public int getCol(){
        return col_;
    }
    public void setCol(int col){col_=col;}

    void OnEnable()
    {
       mState= BallState.Spawned;
    }

    
}
