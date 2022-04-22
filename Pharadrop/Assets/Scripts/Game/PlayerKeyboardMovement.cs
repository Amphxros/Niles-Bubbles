using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeyboardMovement : MonoBehaviour
{
    float speed_;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x= Input.GetAxis("Horizontal");

        transform.Rotate(new Vector3(0,0 speed_*x);
    }
}
