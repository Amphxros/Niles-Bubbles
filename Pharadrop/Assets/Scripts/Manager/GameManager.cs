using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

enum State {GAMESCREEN, MENU, CHARACTER_SELECT, LEVEL_SELECT, DIALOG_SCENE, GAME}
public class GameManager : MonoBehaviour
{
    private static GameManager mInstance_;
    public static GameManager getInstance() {  return mInstance_;}

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
        mState= State.GAMESCREEN;
    }

    void Start(){
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene(string name){
        SceneManager.LoadScene(name);
        OnSceneChanged();
    }

    void OnSceneChanged(){
        switch (mState)
        {
            case State.GAMESCREEN:
                mState= State.MENU;
            break;

            case State.MENU:
                mState= State.CHARACTER_SELECT;
            break;

            case State.CHARACTER_SELECT:
                mState= State.LEVEL_SELECT;
            break;

            
            case State.LEVEL_SELECT:
                mState= State.DIALOG_SCENE;
            break;

            case State.DIALOG_SCENE:
                mState= State.GAME;
            break;

            case State.GAME:
                mState= State.LEVEL_SELECT;
            break;

            default:
                break;
        }
    }
}
