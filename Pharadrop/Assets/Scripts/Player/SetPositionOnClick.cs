using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPositionOnClick : MonoBehaviour
{
    public Transform target;
    
    public Transform UIInfo;
    bool isinPosition = false;
   
   /// <summary>
   /// Start is called on the frame when a script is enabled just before
   /// any of the Update methods is called the first time.
   /// </summary>
   void Start()
   {
       UIInfo.gameObject.SetActive(false);
   }
    void OnMouseDown()
    {
        if(isinPosition){
            UIInfo.gameObject.SetActive(true);
            isinPosition = false;
           
        }
        else{
            target.position=transform.position;
            isinPosition = true;
        }

        
    }
}
