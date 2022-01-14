using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocityScale=1.0f;
    public bool isComponentActive= true;
 
    private void Start() {
        rb= this.gameObject.GetComponent<Rigidbody2D>();    
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
        
      var speed= rb.velocity.magnitude;

      var dir= Vector3.Reflect(transform.up,other.contacts[0].normal);
      transform.up=dir;
    }
}
