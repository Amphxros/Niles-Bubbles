using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    BallID mID;
    public float velocityScale=1.0f;
    public bool isComponentActive= true;
 
    private void Start() {
        mID= this.gameObject.GetComponent<BallID>();
    }
    public bool isActive(){
        return isComponentActive;
    }
    void Update()
    {
        if(isComponentActive){
            transform.Translate(0, velocityScale * Time.deltaTime, 0);
        }
    }


    private void OnCollisionEnter2D(Collision2D other) {
        
        BallMovement othermov= other.gameObject.GetComponent<BallMovement>();
        if(othermov==null){
            var dir= Vector3.Reflect(transform.up,other.contacts[0].normal);
            transform.up=dir;
        }
        else{
            // si es nuestro rival se destruye la bola

            // si no se posiciona y avisa a la otra
            BallID otherID= other.gameObject.GetComponent<BallID>();
            if(!othermov.isComponentActive){
                isComponentActive=false;

            }            
        }
    }
}
