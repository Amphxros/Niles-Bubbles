using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Globalization;

enum Type{BOSS, MOVES, TIME, POINTS}
public class GridParser : MonoBehaviour
{
    string [,] mLevel;
    Type mType;
    int num=0;

     public static TextInfo Text = new CultureInfo("en-US", false).TextInfo;

    void Start(){

    }

    public void loadFile(string filename){
        StreamReader read= new StreamReader(filename);
        if(File.Exists(filename)){
              char[,] tempTab= new char[200,200];

                    int h_ = 0;
                    int w_ = 0;
                   

                    //Read the whole file and save it temporaly
                    while (!read.EndOfStream)
                    {
                        string s= read.ReadLine();                        
                        string [] line= s.Split(' ');
                        if(h_==0){
                            mType= (Type)Enum.Parse(typeof(Type), Text.ToUpper(s[0]));
                        }
                        else{
                            w_ = line.Length;
                            for (int i = 0; i < w_; i++)
                            {
                                tempTab[i, h_] = line[i];
                            }   

                        }
                        h_++;
                    }
                    width = w_; 
                    height = h_;
                    //transfer the temporaly to the real tab


        }
        else{
            Debug.LogError("File doesnt exist");
        }
    }
 
}
