
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitManager : MonoBehaviour
{
    float time_;
    void Start()
    {
        Invoke("GoToMainMenu",1);
    }

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        
    }

    void GoToMainMenu(){
        GameManager.getInstance().ChangeScene("MenuPrincipal");
    }
}
