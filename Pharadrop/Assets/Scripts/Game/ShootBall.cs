using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall : MonoBehaviour
{
    GameObject mShoot_;

    public void SpawnBall(GameObject b){
       
        mShoot_=b;
    }

    public void Shoot(){
        BallMovement g= mShoot_.GetComponent<BallMovement>();

        if(g!=null){
            g.setActive(true);
            mShoot_= null;
        }

    }
    
}
