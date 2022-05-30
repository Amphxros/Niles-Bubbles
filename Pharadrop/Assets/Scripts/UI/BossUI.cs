using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BossUI : MonoBehaviour
{
    int playerHP=0;
    int bossHP=0;

    public Transform playerPanel;
    public Transform bossPanel;

    public Text playername;
    public Text bossName;



    public GameObject [] bossesArt;

    void OnEnable()
    {
        Debug.Log("Boss initialized");
    }
    public void setPlayer(string name){
      int i= 0;
       switch(name){
           case "Bastet":
           i=0;
           break;
           case "Isis":
           i=1;
           break;

           case "Neftis":
           i=2;
           break;

           
       }
        print("player" +i);
       Instantiate(bossesArt[i],playerPanel.transform);
        
    }

    public void setBoss(string name){
      int i= 0;
       
       switch(name){
        case "Bastet":
           i=0;
           break;
           
        case "Isis":
           i=1;
           break;

        case "Neftis":
           i=2;
           break;

            default:
            i=0;
            break;

       }
       print("boss" +i);

       Instantiate(bossesArt[i], bossPanel.transform);
        
    }


    public void SetPlayerHP(int hp){
        playerHP=hp;
        //cambiar la barra de vida
    }

    public void SetBossHP(int hp){
        bossHP=hp;
         //cambiar la barra de vida
    }

}
