using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float velocityScale=1.0f;
    public bool isComponentActive= true;
 
    
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
        
        BallMovement ball= other.gameObject.GetComponent<BallMovement>();
        if(ball==null){
            Vector2 aux= transform.up;
            Vector2 normal= other.gameObject.transform.right;

            transform.up= normal - aux;
        }
        else{
            if(ball.isActive()){
                isComponentActive= false; //deja de moverse una vez ha colisionado con otra bola
            }
        }
        
    }
}
