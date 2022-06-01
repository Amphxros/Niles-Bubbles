using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

     public GameObject gameWin;
    public GameObject gameLose;
    public GameObject gamePause;
    void Start()
    {
        gameWin.SetActive(false);
        gameLose.SetActive(false);
        gamePause.SetActive(false);
        
    }

    public void PauseGame(){
        Time.timeScale=0;
        gamePause.SetActive(true);

    }
    public void ResumeGame(){
        Time.timeScale=1;
        gamePause.SetActive(false);
    }

    public void GameWin(int score, string character){

    }
}

