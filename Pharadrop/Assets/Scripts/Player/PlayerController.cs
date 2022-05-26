using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    BallPool pool;
    Vector3 pointingTarget;
  
  /// <summary>
  /// Start is called on the frame when a script is enabled just before
  /// any of the Update methods is called the first time.
  /// </summary>
  void Start()
  {
      pool= GetComponent<BallPool>();
  }
  
    void Update() {
        pointingTarget = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.back * Camera.main.transform.position.z);
        Vector3 look=transform.position+ pointingTarget;

        look= new Vector3(look.x,Mathf.Abs(look.y),Mathf.Abs(look.z));
        transform.up=look;

        if(Input.GetMouseButtonUp(0)){
            pool.Activate();
        }
    }

    void OnDrawGizmos() {
        Gizmos.DrawSphere(pointingTarget, 0.2f);
        Gizmos.DrawLine(transform.position, pointingTarget);
    }
}
