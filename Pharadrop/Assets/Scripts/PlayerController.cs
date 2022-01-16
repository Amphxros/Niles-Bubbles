using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float scale=5.0f;
    ShootComponent mShootComponent;

    private void Start() {
        mShootComponent= this.gameObject.GetComponent<ShootComponent>();    
    }


    void Update()
    {
        float x= Input.GetAxis("Horizontal");

        Vector2 aux= transform.up;
        if(x > 0){
            transform.up = aux + new Vector2(scale* Time.deltaTime,0);
        }
        else if(x < 0){
            
            transform.up= aux - new Vector2(scale* Time.deltaTime,0);
        }
           
        if(Input.GetKeyDown(KeyCode.Space)){
            mShootComponent.Shoot();
        }

    }
}
