using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDamage : MonoBehaviour
{
    [Header("vida inicial del boss")]
    public int maxLife;
    private float currentLife;
    void Start()
    {
        currentLife=maxLife;
    }

    public void LoseLife(int damage){
        currentLife-=damage;

    }
    public bool IsDead(){
        return currentLife<=0;
    }


}
