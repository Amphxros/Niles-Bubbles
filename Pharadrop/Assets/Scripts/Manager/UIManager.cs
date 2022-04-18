using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject configPanel;

    public GameObject mainMenuPanel_;

    public GameObject shopPanel_;


    void Awake()
    {
        
        
        if(GameManager.getInstance().getUIMngr()==null){
            GameManager.getInstance().setUI(this);
        }
        


        configPanel.SetActive(false);
        //mainMenuPanel_.SetActive(false);
        shopPanel_.SetActive(false);

    

    }
    public void onMenuState(){
         configPanel.SetActive(false);
        mainMenuPanel_.SetActive(false);
        shopPanel_.SetActive(false);

         mainMenuPanel_.SetActive(true);
    }

    public void onConfigState(){
         configPanel.SetActive(true);
        mainMenuPanel_.SetActive(false);
        shopPanel_.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
