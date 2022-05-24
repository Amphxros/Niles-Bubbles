using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovesUI : MonoBehaviour
{
   
    int minScore;
    int currScore_;


    public Text currScoreText;
    public Text minScoreText;
    

    public Text movesText;
    int mMoves_;

    void OnEnable()
    {
       setMoves(1);

    }

    public void setCurrScore(int score){
        currScore_=score;
        currScoreText.text=score + " ";
    }

    public void setMoves(int moves){
        mMoves_=moves;
        movesText.text= moves.ToString();
    }

    public void OnShoot(){
        mMoves_--;
        movesText.text= moves.ToString();

        if(mMoves_<=0){

        }
    }
    void OnMovesZero(){
        if(currScore_>=minScore){

        }
        else{
            
        }
    }

    }
