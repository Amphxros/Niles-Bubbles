using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroManager : MonoBehaviour
{
    public PapiroIntro pap;
    public GameObject[] introPanel;
    int index=0;
    void Start()
    {
        for(int i=1; i<introPanel.Length; i++){
            introPanel[i].SetActive(false);
        }

        Invoke("changeByTime", 15);
        
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            GameManager.getInstance().ChangeScene("MenuPrincipal");
        }
    }

    void changeByTime(){
        index++;
        pap.Move();
        if(index<introPanel.Length){
 
          for(int i=0; i<introPanel.Length; i++){
            introPanel[i].SetActive(false);
          }
          introPanel[index].SetActive(true);

          Invoke("changeByTime", 10);
        }

        else{
            GameManager.getInstance().ChangeScene("MenuPrincipal");
        }

    }
}
