using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CharacterSelector : MonoBehaviour
{
   public GameObject [] characters;
   int ind=0;
    void Start()
    {
        for(int i=0; i<characters.Length; i++)
        {
            characters[i].SetActive(false);
        }

        characters[ind].SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextCharacter(){
        characters[ind].SetActive(false);
        ind= (ind+1)%characters.Length;
        characters[ind].SetActive(true);
    }
    public void BeforeCharacter(){
        characters[ind].SetActive(false);
        
        if(ind==0){
            ind=characters.Length;
        }
        
        ind= (ind-1)%characters.Length;
        characters[ind].SetActive(true);
    
    }
}
