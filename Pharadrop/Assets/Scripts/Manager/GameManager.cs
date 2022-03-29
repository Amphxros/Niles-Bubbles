using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

enum State {GAMESCREEN, MENU, CHARACTER_SELECT, LEVEL_SELECT, DIALOG_SCENE, GAME}
public class GameManager : MonoBehaviour
{
    private int bgm_volume, sfx_volume;
    private static GameManager mInstance_;
    public static GameManager getInstance() {  return mInstance_;}


    public ConfigManager mConfigManager_;


    private State mState;

    
    void Awake()
    {
        
        if(mInstance_==null){
            mInstance_=this;
             DontDestroyOnLoad(this.gameObject);
        }
        else{
            Destroy(this);
        }
        mConfigManager_= null;
        mState= State.GAMESCREEN;
        
    }


    public ConfigManager getConfig(){
        return mConfigManager_;
    }

    public void setConfigManager(ConfigManager config){
        mConfigManager_=config;
    }

    public void ChangeScene(string name){
        SceneManager.LoadScene(name);
        
    }

}
