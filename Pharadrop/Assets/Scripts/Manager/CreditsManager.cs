using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsManager : MonoBehaviour
{
    public Transform creditsPanel;
    public Transform additionalcreditsPanel;

    int i=0;

    void Start()
    {
        additionalcreditsPanel.gameObject.SetActive(false);
    }

    public void plus(){
        i++;

        if(i%2==0){
            additionalcreditsPanel.gameObject.SetActive(false);
            creditsPanel.gameObject.SetActive(true);
        }
        else{
            additionalcreditsPanel.gameObject.SetActive(true);
            creditsPanel.gameObject.SetActive(false);
        }

    }
    

      public void minus(){
        i--;

        if(i%2==0){
            additionalcreditsPanel.gameObject.SetActive(false);
            creditsPanel.gameObject.SetActive(true);
        }
        else{
            additionalcreditsPanel.gameObject.SetActive(true);
            creditsPanel.gameObject.SetActive(false);
        }

    }

  
}
