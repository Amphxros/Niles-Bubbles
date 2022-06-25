using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Line{
    public Line(){
        person="";
        dialog="";
    }
    public string person;
    public string dialog;
}

public class DialogManager : MonoBehaviour
{
    public string file;
    public string scene;

    Line[] data;
    
    int i=0;
    bool readed=false;

    public GameObject[] characters;

    public RectTransform player;
    public RectTransform boss;
    
    public Text name;
    public Text dialog;

    // Start is called before the first frame update
    void Start()
    {
        i=0;
        string path= Application.dataPath + "/" +  file;
        Debug.Log("path");
        ReadFile(path);
        Debug.Log("read");
        
    }

    public void ReadFile(string path){

        StreamReader read= new StreamReader(path);
        if(File.Exists(path)){
            string line= read.ReadLine();
            string [] l=line.Split(' ');
            setPlayer(l[0]);
            setBoss(l[1]);
            
            int j=0;
            string[] tmp= new string[100];
            while(!read.EndOfStream){
                line= read.ReadLine();
                tmp[j]=line;
                j++;
            }
             data= new Line[j];
             for(int k=0;k<j; k++){
                 l= tmp[k].Split(' ');
                 data[k]= parseLine(l);
             }
        }
        readed=true;

        
        


    }

    Line parseLine(string[] split){
        Line l=new Line();

        l.person= split[0];
        l.dialog="";
        for(int j=1;j<split.Length;j++){
            l.dialog+= split[j]+ " ";
        }

        return l;
    }

    void setPlayer(string s){
        switch (s)
        {
            case "BASTET":
             Instantiate(characters[0], player.transform);
            break;

            
            case "ISIS":
             Instantiate(characters[1], player.transform);
            break;
            
            case "NEFTIS":
             Instantiate(characters[2], player.transform);
            break;
            
            
            default:
            break;
        }
    }
    
       void setBoss(string s){
        switch (s)
        {
            case "BASTET":
             Instantiate(characters[0], boss.transform);
            break;

            
            case "ISIS":
             Instantiate(characters[1], boss.transform);
            break;
            
            case "NEFTIS":
             Instantiate(characters[2], boss.transform);
            break;
            
            
            default:
            break;
        }
    }

    void Update()
    {
        if(readed){
            name.text= data[i].person;
            dialog.text= data[i].dialog;

            if(Input.GetKeyUp(KeyCode.Space)){
                i++;
            if(i==data.Length){
                GameManager.getInstance().ChangeScene(scene);
            }
            }
         }


    }

    
}

