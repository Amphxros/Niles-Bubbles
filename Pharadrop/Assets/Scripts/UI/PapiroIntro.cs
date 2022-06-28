using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PapiroIntro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Move()
    {
        transform.position+= new Vector3(0,-155.0f,0);
    }
}
