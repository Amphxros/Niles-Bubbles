using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class SaveManager : MonoBehaviour
{
    public string savePath;
    
    void Start()
    {
       

        
    }

    public bool Load(){
      
        return true;
    }

    public void Save(string route, int level){
        savePath = Application.dataPath + "/" + "save.dat";
        StreamWriter write = new StreamWriter(savePath);
        switch(route){
            case "Bastet":
            write.WriteLine("BASTET + " + level);
            break;
            case "Isis":
            write.WriteLine("ISIS + " + level);
            break;
            case "Neftis":
            write.WriteLine("NEFTIS + " + level);
            break;
        }
        write.Close();
    }

   
}
