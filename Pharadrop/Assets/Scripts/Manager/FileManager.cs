using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public enum LevelType{ BOSS, TIME, SCORE, MOVES}

public struct LevelData{
    public LevelType type;
    public int args;
    public string args1;
    public string args2;
    public int args3;
    public int args4;
}
public class FileManager : MonoBehaviour
{

    public GameObject [] mPrefabs_; 
    public Vector3 initPosition;
    string [] dataArray;
    string mFilePath;
    public string filename;


    LevelData mData;

    public LevelData getType(){
        return mData;
    }
    
    void Awake()
    {
        mFilePath=Application.dataPath +"/" + filename;
    }

    public string[] getData(){
        return dataArray;
    }
    public void ReadFromFile(){
       
        StreamReader read= new StreamReader(mFilePath);
        if(File.Exists(mFilePath)){
            string line= read.ReadLine();
            string [] split= line.Split(' ');

            switch (split[0])
            {
                case "BOSS":
                 mData.type= LevelType.BOSS;
                 mData.args1=split[1];
                 mData.args2= split[2];

                 mData.args3= int.Parse(split[3]);
                 mData.args4= int.Parse(split[4]);

                 print(mData.args1 + " " + mData.args2);

                break;

                case "TIME":
                mData.type= LevelType.TIME; 
                mData.args= int.Parse(split[1]);
                mData.args1=split[2];


                break;
                
                case "SCORE":
                mData.type= LevelType.SCORE;
                mData.args= int.Parse(split[1]);
                break;
                
                case "MOVES":
                mData.type=LevelType.MOVES;
                mData.args= int.Parse(split[1]);
                mData.args1= split[2];
                break;
               
            }
            
            string [] data= new string[100];
            int fils= 0;
            while(fils<data.Length && !read.EndOfStream){
                line= read.ReadLine();
                data[fils]= line;
                fils++;
                Debug.Log(line);
            
            }
            dataArray= new string[fils];
            for(int i=0 ;i<fils; i++){
                dataArray[i]= data[i];
            }


        }
        else{
            Debug.LogError("No existe fichero" + filename);
        }
    }




}
