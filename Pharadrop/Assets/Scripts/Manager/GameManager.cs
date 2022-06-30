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
  
    SaveManager save;
    
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
       false,
        false,
        false,
        false,
        false
    };
    private bool[] neftisRouteLevels= {
        false,
        false,
        false,
        false,
        false
    };


    void Awake()
    {   
        if(mInstance_==null){
            mInstance_=this;
            save= new SaveManager();
            save.Load();
            DontDestroyOnLoad(this.gameObject);
        }
        else{
            Destroy(this.gameObject);
        }
       
    }

    public void ChangeScene(string name){
        SceneManager.LoadScene(name);
        
    }

    public bool isLocked(string route, int level){
        switch (route)
        {
            case "BASTET":
                return !bastetRouteLevels[level];
            case "ISIS":
                return !isisRouteLevels[level];
            case "NEFTIS":
                return !neftisRouteLevels[level];
            default:
                return false;
        }
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
        if(!isLocked(route,level)){
            ChangeScene(name);
        }
    }


    
}
