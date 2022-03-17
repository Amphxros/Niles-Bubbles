using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    FileManager mManager_;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        mManager_= GetComponent<FileManager>();

        if(mManager_!=null){
            mManager_.ReadFromFile();
            mManager_.CreateLevel();
        }
        else{
            Debug.Log("no leido no existente");
        }
    }
}
