using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossUI : MonoBehaviour
{
    int playerHP;
    int bossHP;

    public Transform playerPanel;
    public Transform bossPanel;


    public GameObject [] bossesArt;
    public string [] bossesName;

    void OnEnable()
    {
        
    }
    public void setPlayer(string name){
      int i= 0;
      while(i<bossesName.Length && bossesName[i]!=name)
        i++;

        if(i<bossesName.Length){
            Instantiate(bossesArt[i],playerPanel.position,playerPanel.rotation);
        }
    }

    public void setBoss(string name){
      int i= 0;
      while(i<bossesName.Length && bossesName[i]!=name)
        i++;

        if(i<bossesName.Length){
            Instantiate(bossesArt[i], bossPanel.position, bossPanel.rotation);
        }
    }


    public void SetPlayerHP(int hp){
        playerHP=hp;
        //cambiar la barra de vida
    }

    public void SetBoss(int hp){
        bossHP=hp;
         //cambiar la barra de vida
    }

}
