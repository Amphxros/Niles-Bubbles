using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Globalization;
using System;
public enum TypeLevel{ BOSS, MOVS, TEMP, SCORE};


public class GridReader : MonoBehaviour
{
    private static TextInfo Text = new CultureInfo("en-US", false).TextInfo;
    private  TypeLevel mLevelType_;   
    private int arg=-1;
    
    public void readFile(string filename){
        StreamReader read= new StreamReader(filename);
        string type="";
        if(File.Exists(filename)){
            int fils=0;
            int cols=0;

            string [] tmp= new string[100];
            type= read.ReadLine();
            ParseLevelType(type);
            

        }
        else{
            Debug.LogError("archivo no encontrado");
        }
        
    }

    private void ParseLevelType(string type){

        string[] line= type.Split(' ');
        mLevelType_= (TypeLevel)Enum.Parse(typeof(TypeLevel), Text.ToUpper(line[0]));
        arg= int.Parse(line[1]);
    }
}
