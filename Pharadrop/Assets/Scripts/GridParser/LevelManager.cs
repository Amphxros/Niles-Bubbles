using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public string mLevelRoute;
    GridReader mGrid;
    TypeLevel mType_;

    public GameObject mPool;
    public GameObject [] mBalls;
    private string[] mLevel;
    
    private GameObject[,] grid;
    private void Awake() {

    }
    void Start()
    {
        mGrid= new GridReader();
        mLevel= mGrid.readFile(mLevelRoute);
        mType_= mGrid.getLevelType();
        
        grid= new GameObject[mGrid.getFils(), mGrid.getCols()];

        for(int i=0;i<mLevel.Length;i++){
            for(int j=0 ; j<mLevel[i].Length; j++){
                switch(mLevel[i][j]){
                    case '.':
                    // espacio vacio
                        grid[i,j]=null;
                    break;
                    case 'A':
                        GameObject gA= Instantiate(mBalls[0], new Vector3(2*i + (j%2), j,0), Quaternion.identity,mPool.transform);
                        grid[i,j]=gA;
                    break;
                    
                    case 'B':
                        GameObject gB= Instantiate(mBalls[1], new Vector3(2*i + (j%2), j,0), Quaternion.identity,mPool.transform);
                        grid[i,j]=gB;
                    break;
                    
                    case 'C':
                        GameObject gC= Instantiate(mBalls[2], new Vector3(2*i + (j%2), j,0), Quaternion.identity,mPool.transform);
                        grid[i,j]=gC;
                   
                    break;
                    
                    case 'D':
                        GameObject gD= Instantiate(mBalls[3], new Vector3(2*i + (j%2), j,0), Quaternion.identity,mPool.transform);
                        grid[i,j]=gD;
                    break;

                }
            } 
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
