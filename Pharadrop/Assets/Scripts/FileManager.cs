using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public enum LevelType{ HP, TIME, SCORE, MOVES}

public struct LevelData{
    public LevelType type;
    public int args;
}
public class FileManager : MonoBehaviour
{

    string [] namesArray;
    string mFilePath;
    public string filename;

    LevelData mData;
    
    void Start()
    {
        mFilePath=Application.dataPath +"/" + filename;

        ReadFromFile();
    }

    public void ReadFromFile(){
       
        StreamReader read= new StreamReader(mFilePath);
        if(File.Exists(mFilePath)){
            string line= read.ReadLine();
            string [] split= line.Split(' ');

            switch (split[0])
            {
                case "HP":
                mData.type= LevelType.HP;
                break;

                case "TIME":
                mData.type= LevelType.TIME;    
                break;
                
                case "SCORE":
                mData.type= LevelType.SCORE;
                break;
                
                case "MOVES":
                mData.type=LevelType.MOVES;
                break;
               
            }

            mData.args= int.Parse(split[1]);

            string [] data= new string[100];
            int fils= 0;
            while(fils<data.Length && !read.EndOfStream){
                line= read.ReadLine();
                data[fils]= line;
                fils++;
                Debug.Log(line);
            }          
        }
        else{
            Debug.LogError("No existe fichero" + filename);
        }
    }

}
