using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ConfigManager : MonoBehaviour
{
    public Text resolutions_text;
    public Text bgm_text;
    public Text sfx_text;
    
    bool fullscreen=false;

    Resolution[] mResolutions;

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
        if(mResIndex>0){
            mResIndex--;
            print(mResIndex);
            Screen.SetResolution(mResolutions[mResIndex].width, mResolutions[mResIndex].height, true);
        }

        updateResText();
    }
    
    public void MoreRes(){
        if(mResIndex < mResolutions.Length){
            mResIndex++;
            Screen.SetResolution(mResolutions[mResIndex].width, mResolutions[mResIndex].height, true);
        }
        updateResText();
    }


    public void LessBGMVolume(){

    }
    
    public void MoreBGMVolume(){
        
    }


    public void LessSFXVolume(){

    }
    
    public void MoreSFXVolume(){
        
    }


}
