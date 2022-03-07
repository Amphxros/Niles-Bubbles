using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

enum LevelType{ HP, TIME, SCORE}
public class FileManager : MonoBehaviour
{
    string [] namesArray;
    string mFilePath;
    public string filename;

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

            Debug.Log(split[0] + " ");

          
        }
        else{
            Debug.LogError("No existe fichero" + filename);
        }
    }

}
