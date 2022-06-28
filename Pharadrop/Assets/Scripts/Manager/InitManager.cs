
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitManager : MonoBehaviour
{
    float time_;
    void Start()
    {
        GameManager.getInstance().ChangeScene("IntroHistoria");
    }
}
