using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPool : MonoBehaviour
{

    public GameObject[] pool;

    GameObject mBall;
    int i=0;

    void Start(){
       SpawnBall(); 
    }

   public void SpawnBall(){
       if(mBall==null){
           mBall= Instantiate(pool[i%pool.Length], transform) as GameObject;
           i++;
       }
   }
   public void Activate(){
       
       BallMovement b= mBall.GetComponent<BallMovement>();
       b.Activate();
       mBall=null;

       SpawnBall();
   }
}
