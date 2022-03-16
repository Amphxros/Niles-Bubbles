using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsUI : MonoBehaviour
{
    Text mText_;
   void Start(){
       mText_= GetComponent<Text>();
   }

   public void OnPointsChanged(int points){
       mText_.text= points.ToString();
   }
}
