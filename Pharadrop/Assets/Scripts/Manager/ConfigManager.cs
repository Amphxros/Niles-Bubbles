using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ConfigManager : MonoBehaviour
{

    private Resolution mResolution_;
    private int mBGMVolume_;
    private int mSFXVolume_;
    


    public Text resolutions_text;
    public Text bgm_text;
    public Text sfx_text;
    
    bool fullscreen=false;

    Resolution[] mResolutions; //list of all the resolutions possibles

    int mResIndex;
    int mVolIndex;
    int mSfxIndex;

    void Awake()
    {
        mResIndex=0;
        mVolIndex=0;
        mSfxIndex=0;

        updateResText();
    }

    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    void OnEnable()
    { 
        updateResText();
        mResolution_= Screen.currentResolution;
    }

    public void ResetConfig(){
        
        print("Reset");
        Screen.SetResolution(mResolution_.width, mResolution_.height,false);
    }
 
    void updateResText(){
        mResolutions = Screen.resolutions;
        Resolution mRes= Screen.currentResolution;
        resolutions_text.text=mRes.width + "x" + mRes.height;

        while (mRes.width!=mResolutions[mResIndex].width && mResIndex<mResolutions.Length)
        {
            mResIndex++;
        }
      
    }

    public void LessRes(){
        print("Less Resolution");
        if(mResIndex>0){
            mResIndex--;
            print(mResolutions[mResIndex].width +"x"+ mResolutions[mResIndex].height);
            Screen.SetResolution(mResolutions[mResIndex].width, mResolutions[mResIndex].height, false);
            Resolution mRes= Screen.currentResolution;
            resolutions_text.text=mRes.width + "x" + mRes.height;
        }
       

        updateResText();
    }
    
    public void MoreRes(){
        
        print("More Resolution");
        if(mResIndex < mResolutions.Length -1){
            mResIndex++;
            print(mResolutions[mResIndex].width +"x"+ mResolutions[mResIndex].height);
            Screen.SetResolution(mResolutions[mResIndex].width, mResolutions[mResIndex].height, false);
        }
        updateResText();
    }


    public void LessBGMVolume(){
        
        print("Less Volume");

    }
    
    public void MoreBGMVolume(){
        
        print("MoreVolume");
    }


    public void LessSFXVolume(){
        
        print("Less SFX Volume");
    }
    
    public void MoreSFXVolume(){
        
        print("More SFX volume");
    }


}
