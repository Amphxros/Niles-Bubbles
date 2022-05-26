using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed;

    bool activated=false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(activated)
          transform.Translate(0, speed * Time.deltaTime, 0);
    }

    public void Activate(){
        activated=true;
        this.transform.parent=null;
    }
    public void Desactivate(){
        activated=false;
    }

    void deleteComponent(){
        Destroy(this);
    }

      private void OnCollisionEnter2D(Collision2D other) {
        var dir= Vector3.Reflect(transform.up,other.contacts[0].normal);
        transform.up=dir;
    }
}
