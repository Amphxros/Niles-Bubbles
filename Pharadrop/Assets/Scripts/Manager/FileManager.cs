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

    public GameObject [] mPrefabs_; 
    public Vector3 initPosition;
    string [] dataArray;
    string mFilePath;
    public string filename;

    LevelData mData;
    
    void Awake()
    {
        mFilePath=Application.dataPath +"/" + filename;
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

            dataArray= new string[fils];

            for(int i=0 ;i<fils; i++){
                dataArray[i]= data[i];
            }


        }
        else{
            Debug.LogError("No existe fichero" + filename);
        }
    }

    public void CreateLevel(){
        if(dataArray.Length > 0){
            for(int i=0; i<dataArray.Length; i++){
                string[] line= dataArray[i].Split(' ');
                for(int j=0;j<line.Length; j++){
                    GameObject g;
                    switch(line[j]){
                        case "A":
                            g= Instantiate(mPrefabs_[0], initPosition + new Vector3(j -(j%2)/2,i, 0), Quaternion.identity, this.gameObject.transform);
                        break;
                        case "B":
                        
                            g= Instantiate(mPrefabs_[1],initPosition +  new Vector3(j -(j%2)/2,i, 0), Quaternion.identity, this.gameObject.transform);
                        break;
                        case "C":
                        
                            g= Instantiate(mPrefabs_[2], initPosition + new Vector3(j -(j%2)/2,i, 0), Quaternion.identity, this.gameObject.transform);
                        break;
                        case "D":
                        
                            g= Instantiate(mPrefabs_[3],initPosition +  new Vector3(j -(j%2)/2,i, 0), Quaternion.identity, this.gameObject.transform);
                        break;
                        case "E":
                        
                            g= Instantiate(mPrefabs_[4], initPosition + new Vector3(j -(j%2)/2,i, 0), Quaternion.identity, this.gameObject.transform);
                        break;
                        default:
                        
                            g= Instantiate(mPrefabs_[0], initPosition + new Vector3(j -(j/2)/2,i, 0), Quaternion.identity, this.gameObject.transform);
                        break;
                        
                    }

                    
                }
            }
        }
    }



}
