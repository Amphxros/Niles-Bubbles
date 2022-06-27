using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnClick : MonoBehaviour
{
    private AudioSource src;

    void Start()
    {
        src= GetComponent<AudioSource>();   
    }
    
    public void play(){
        src.Play();
    }
}
