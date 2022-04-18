using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

enum State {GAMESCREEN, CONFIG, MENU, CHARACTER_SELECT, LEVEL_SELECT, DIALOG_SCENE, GAME}
public class GameManager : MonoBehaviour
{
    private int bgm_volume, sfx_volume;
    private static GameManager mInstance_;
    public static GameManager getInstance() {  return mInstance_;}

    private UIManager mUI_;

 
    private State mState;

    Stack<State> mStates;
    Stack<string> mLevels;
 

    void Awake()
    {

        
        if(mInstance_==null){
            mInstance_=this;
             DontDestroyOnLoad(this.gameObject);
        }
        else{
            Destroy(this);
        }
        mStates= new Stack<State>();
        mState= State.GAMESCREEN;
        mStates.Push(mState);
        mUI_=null;
    }

    public void MenuState(){
        mState=State.GAMESCREEN;
        mStates.Push(mState);
        mUI_.onMenuState();
    }

    public void ConfigState(){
        mState=State.CONFIG;
        mStates.Push(mState);
      
    }

    public void OnGameStart(){
         mState=State.GAME;
        mStates.Push(mState);
    }
    public void goBack(){
        if(mStates.ToArray().Length>=1){
            mStates.Pop();

            State prev= mStates.Peek();

            switch(prev){
                case State.GAMESCREEN:
                ChangeScene("MenuPrincipal");
                break;
                case State.GAME:                
                ChangeScene(mLevels.Peek());
                mLevels.Pop();
                break;
                case State.LEVEL_SELECT:
                ChangeScene("Selection");
                break;
                case State.DIALOG_SCENE:
                ChangeScene("Dialogs");
                break;
                
            }
        }
    }

    public void setUI(UIManager mngr){
        mUI_=mngr;
    }

    public UIManager getUIMngr(){
        return mUI_;
    }
    
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
       
    }

    public void ChangeScene(string name){
        SceneManager.LoadScene(name);
        
    }

    public void ConfigurationsStart(){
        mState=State.CONFIG;

     
    }

     public void ConfigurationsEnd(){
        mState=State.CONFIG;

     
     }


}
