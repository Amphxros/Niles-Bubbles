using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Globalization;
using System;
public enum TypeLevel{NONE, BOSS, MOVS, TEMP, SCORE};


public class GridReader
{
    private static TextInfo Text = new CultureInfo("en-US", false).TextInfo;
    private  TypeLevel mLevelType_;   
    private int arg=-1;
    int fils=0;
    int cols=0;
    

    public GridReader(){
        arg=-1;
        mLevelType_= TypeLevel.NONE;

    }
    public TypeLevel getLevelType(){ return mLevelType_;}

    public int getFils(){return fils;}
    public int getCols(){return cols;}
    public string[] readFile(string filename){
        StreamReader read= new StreamReader(filename);
        string type="";
        if(File.Exists(filename)){

            string [] tmp= new string[100];
            type= read.ReadLine();

            // parseamos el tipo de nivel
            string[] line= type.Split(' ');
            mLevelType_= (TypeLevel)Enum.Parse(typeof(TypeLevel), Text.ToUpper(line[0]));
            arg= int.Parse(line[1]);

            // leemos lo temporal
            int i=0;
            while(i<tmp.Length && !read.EndOfStream){
                tmp[i]=read.ReadLine();
                line= type.Split(' ');
                i++;
                cols=line.Length;
            }
            fils=i;

            return tmp;
            

        }
        else{
            Debug.LogError("archivo no encontrado");
        }

        return null;
        
    }


}
