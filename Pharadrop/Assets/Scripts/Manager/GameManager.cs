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
}
