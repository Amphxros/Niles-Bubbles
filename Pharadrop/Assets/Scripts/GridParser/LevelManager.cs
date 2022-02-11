using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public string mLevelRoute;
    GridReader mGrid;
    TypeLevel mType_;

    public char [] mKeyChars;
    public GameObject [] mBalls;
    private string[] mLevel;
    void Start()
    {
        mGrid= new GridReader();
        mLevel= mGrid.readFile(mLevelRoute);
        mType_= mGrid.getLevelType();
        

        for(int i=0;i<mLevel.Length;i++){
            string [] line= mLevel[i].Split(' ');
            for(int j=0 ; j<line.Length; j++){
                
            } 
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
