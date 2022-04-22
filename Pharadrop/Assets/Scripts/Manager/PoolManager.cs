using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
   public Stack<GameObject> mBallData_;
    private ShootBall mShoot_;
   /// <summary>
   /// Start is called on the frame when a script is enabled just before
   /// any of the Update methods is called the first time.
   /// </summary>
   void Start()
   {
       mShoot_= GetComponent<ShootBall>();
   }

   public bool isEmpty(){
        return false;
   }

   public void addBall(){
       GameObject g= mBallData_.Peek();
        Instantiate(g, this.transform.position, Quaternion.identity);
       mShoot_.SpawnBall(g);
   }
}
