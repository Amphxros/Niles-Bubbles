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
            BallID bA= this.gameObject.GetComponent<BallID>();
            BallID bb= other.gameObject.GetComponent<BallID>();

            int i=bA.indX;
            int j = bA.indY;

            AttachToGridOnTrigger a= other.gameObject.AddComponent<AttachToGridOnTrigger>();
            a.setGrid(g);
            
            //position to attach to
            if(this.transform.position.x - other.transform.position.x>0){
                if(this.transform.position.y - other.transform.position.y>0){
                    g.attachBall(other.gameObject,i+1,j);
                }
                else{
                    g.attachBall(other.gameObject,i-1,j);
                }
            }
            else{

                if(this.transform.position.y - other.transform.position.y>0){
                     g.attachBall(other.gameObject,i+1,j+1);
                }
                else{
                   g.attachBall(other.gameObject,i+1,j+1);
                }

            }


            

        }
    }
}
