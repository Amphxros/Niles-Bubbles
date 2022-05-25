using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          transform.Translate(0, speed * Time.deltaTime, 0);
    }

    void deleteComponent(){
        Destroy(this);
    }

      private void OnCollisionEnter2D(Collision2D other) {
        var dir= Vector3.Reflect(transform.up,other.contacts[0].normal);
        transform.up=dir;
    }
}
