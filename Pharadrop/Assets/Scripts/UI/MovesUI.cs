using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MovesUI : MonoBehaviour
{
   
    int minScore;
    int currScore_;


    public Text currScoreText;
    public Text minScoreText;
    public Text movesText;

    public RectTransform characterImage;
    public Image [] characters;


    int mMoves_=0;


    public GameObject gameWin;
    public GameObject gameLose;

   

    void OnEnable()
    {
        Debug.Log("Moves initialized");
    }

    public void setImage(string character){
        switch (character)
        {
            case "BASTET":
            Instantiate(characters[0],characterImage.transform);
            break;
            
            case "ISIS": Instantiate(characters[1],characterImage.transform);
            break;

            case "NEFTIS": Instantiate(characters[2],characterImage.transform);
            break;
            
            
            default:
            break;
        }
    }

    public void updateScore(int n){
        currScore_+=n;
        currScoreText.text=currScore_.ToString();
    }


    public void setCurrScore(int score){
        currScore_=score;
        currScoreText.text=score + " ";
    }

    public void setMinScore(int score){
        minScore=score;
        minScoreText.text= score.ToString();
    }
    public void setMoves(string moves){
        mMoves_=int.Parse(moves);
        movesText.text= mMoves_ + " ";
    }

    public void OnShoot(){
        mMoves_--;
        movesText.text= mMoves_.ToString();

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
