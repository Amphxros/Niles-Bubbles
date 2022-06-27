using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPositionOnClick : MonoBehaviour
{
    public Transform target;
    
    public Transform UIInfo;
    /// <summary>
    /// OnMouseDown is called when the user has pressed the mouse button while
    /// over the GUIElement or Collider.
    /// </summary>
    void OnMouseDown()
    {
        target.transform.position = transform.position;

        
    }
}
