using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    int minScore;
    int currScore_;


    public Text currScoreText;
    public Text minScoreText;

    void OnEnable()
    {
        
    }

    public void setCurrScore(int score){
        currScore_=score;
        currScoreText.text=score + " ";
    }
    void Start(){
        
    }

    void Update()
    {
        
    }
}
