using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnCollision : MonoBehaviour
{
     private AudioSource source;

    void Start() {
        source = this.GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (source.clip != null) {
            source.Play();
        }
    }
}
