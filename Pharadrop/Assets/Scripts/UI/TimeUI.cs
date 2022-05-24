using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimeUI : MonoBehaviour
{
   
    public Text timeText;
    
    int min, secs;
    int minScore;
    void OnEnable()
    {
        
    }

    public void setTime(string time){
        string [] line= time.Split(':');
        min=int.Parse(line[0]);
        secs= int.Parse(line[1]);

        timeText.text= min + " : "+secs;

    }

    public void setMinScore(int score){
        minScore= score;
    }

    void Update()
    {
        secs-=(int)(Time.deltaTime);
        if(secs<0){
           min--;
           secs=60-secs; 
        }
         timeText.text= min + " : "+secs;

         if(isTimeOver()){
             OnTimeOver();
         }
    }

    void OnTimeOver(){
    
    }

    bool isTimeOver(){
        return min<=0 && secs<=0;
    }
}
