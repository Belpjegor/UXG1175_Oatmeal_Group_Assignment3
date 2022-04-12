using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
 
public static class SaveLoad {
 
    public static List<Character> savedGames = new List<Character>();
             
    //it's static so we can call it from anywhere
    public static void Save() 
    {
        SaveLoad.savedGames.Add(Character.current);
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create (Application.persistentDataPath + "/savedGames.gd"); //you can call it anything you want
        bf.Serialize(file, SaveLoad.savedGames);
        file.Close();
    }   
     
    public static void Load() 
    {
        if(File.Exists(Application.persistentDataPath + "/savedGames.gd")) 
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/savedGames.gd", FileMode.Open);
            SaveLoad.savedGames = (List<Character>)bf.Deserialize(file);
            file.Close();
        }
    }
}