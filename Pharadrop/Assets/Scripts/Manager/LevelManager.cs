using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    FileManager mManager_;

    public GameObject bossUI;
    public GameObject timeUI;
    public GameObject scoreUI;
    public GameObject movesUI;


    private int args_; //time, hp, score...

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        bossUI.SetActive(false);
        timeUI.SetActive(false);
        scoreUI.SetActive(false);
        movesUI.SetActive(false);

        mManager_= GetComponent<FileManager>();

        if(mManager_!=null){
            mManager_.ReadFromFile();
            setUI();
        }
        else{
            Debug.Log("no leido no existente");
        }
    }

    void setUI(){
        LevelData data= mManager_.getType();

        switch (data.type){
            case LevelType.TIME:
            timeUI.SetActive(true);
            TimeUI t= timeUI.GetComponent<TimeUI>();
            t.setMinScore(data.args);
            t.setTime(data.args1.ToString());

            break;

            case LevelType.MOVES:
            movesUI.SetActive(true);
            MovesUI m= movesUI.GetComponent<MovesUI>();
            m.setMinScore(data.args);
            m.setMoves(data.args1);

            break;

            case LevelType.HP:
            break;
        }

    }
}
