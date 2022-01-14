using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootComponent : MonoBehaviour
{
    public float coolingDownSecs, shootCadenceSecs; //coolingDownSecs y cadencia
    private float time_; 
    public GameObject [] balls;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time_ -= Time.deltaTime;
    }

    public void Shoot(){
        if(time_<=0){
            Instantiate(balls[0], transform.position, transform.rotation); //instanciamos el objeto
            time_ = coolingDownSecs;
        }
    }
}
