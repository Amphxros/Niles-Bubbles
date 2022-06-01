using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

enum State {GAMESCREEN, CONFIG, MENU, CHARACTER_SELECT, LEVEL_SELECT, DIALOG_SCENE, GAME}
public class GameManager : MonoBehaviour
{
    private int bgm_volume, sfx_volume;
    private static GameManager mInstance_=null;
    public static GameManager getInstance() {  return mInstance_;}
  

    private bool isBastetUnlocked= false;
    private bool isIsisUnlocked= false;
    private bool isNeftisUnlocked= false;
    private bool[] bastetRouteLevels= {
        true,
        false,
        false,
        false,
        false
    };
    private bool[] isisRouteLevels={
        true,
        false,
        false,
        false,
        false
    };
    private bool[] neftisRouteLevels= {
        true,
        false,
        false,
        false,
        false
    };


    void Awake()
    {   
        if(mInstance_==null){
            mInstance_=this;
            DontDestroyOnLoad(this.gameObject);
        }
        else{
            Destroy(this.gameObject);
        }
       
    }

    public void ChangeScene(string name){
        SceneManager.LoadScene(name);
        
    }
    public void GameOver(){

    }

    public void GameWin(){

    }

    public void unlockLevel(string route, int level){
        switch(route){
            case "Bastet":
            bastetRouteLevels[level]= true;
            break;

            case "Isis":
            isisRouteLevels[level]= true;
            break;

            case "Neftis":  
            neftisRouteLevels[level]= true;
            break;
        }
    }

    public void ChangeSceneIfUnlocked(string name, string route, int level){
        if(isLevelUnlocked(route, level)){
            ChangeScene(name);
        }
    }


    public bool isLevelUnlocked (string route, int level){
         switch(route){
            case "Bastet":
           return bastetRouteLevels[level];
            break;

            case "Isis":
            return isisRouteLevels[level];
            break;

            case "Neftis":  
           return neftisRouteLevels[level];
            break;
        }
        return false;
    }
}
