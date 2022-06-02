using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCharacterToThisPosition : MonoBehaviour
{
  public GameObject character;

  public string charactername;

  public int id;

   void OnMouseDown()
   {
      
        character.transform.position=this.transform.position;
       
   }
}
