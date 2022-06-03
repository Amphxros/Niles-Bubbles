using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachToGridOnTrigger : MonoBehaviour
{
    private Grid g;

    BallMovement ball;
    void Start()
    {
    ball= GetComponent<BallMovement>();
    }

    public bool isGridNull(){
        return g==null;
    }

    public void setGrid(Grid g_){
        g=g_;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        AttachToGridOnTrigger att= other.gameObject.GetComponent<AttachToGridOnTrigger>();
        BallMovement m= other.gameObject.GetComponent<BallMovement>();
        if(att==null && m!=null){
            m.Desactivate();
            AttachToGridOnTrigger a= other.gameObject.AddComponent<AttachToGridOnTrigger>();
            a.setGrid(g);
        }
    }
}
