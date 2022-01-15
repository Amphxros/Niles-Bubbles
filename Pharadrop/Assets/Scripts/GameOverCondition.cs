using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverCondition : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        BallMovement ball= other.gameObject.GetComponent<BallMovement>();
        if(ball!=null && !ball.isComponentActive){
            // poner la pantalla de GameOver
        }    
    }
}
