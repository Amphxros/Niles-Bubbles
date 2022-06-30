using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimeUI : MonoBehaviour
{
   
    public Text timeText;
    
    
    public GameObject gameWin;
    public GameObject gameLose;

    public GameObject gamePause;
    int min;
    float secs;
    int minScore;
    void OnEnable()
    {
        Debug.Log("Time initialized");
    }

    public void setTime(string time){
        string [] line= time.Split(':');
        min=int.Parse(line[0]);
        secs= (float)(int.Parse(line[1]));

        timeText.text= time;
    }


    public void setMinScore(int score){
        minScore= score;
    }

    public void updateScore(int n){

    }

    void Update()
    {
       if(!isTimeOver()){
        secs-=Time.deltaTime;
        if(secs<0){
            min--;
            secs+=60;
        }
        if(secs>10){
            timeText.text=min+":"+ secs.ToString()[0]+""+secs.ToString()[1];
        }
        else{
            timeText.text=min+":"+"0"+secs.ToString()[0];
        }
       }
       else{
           OnTimeOver();
       }



    }

    void OnTimeOver(){
    
    }

    public void addTime(int sec){
        secs+=sec;
        if(secs>60){
            min += (int)(secs%60);
            secs-=60;
        }
    }
    bool isTimeOver(){
        return min<=0 && secs<=0;
    }
}
