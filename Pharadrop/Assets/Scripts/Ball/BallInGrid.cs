using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInGrid : MonoBehaviour
{

    public int BallID=0;


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

    
    
}
