using System.Collections;
using System.Collections.Generic;
using UnityEngine;

   // this script is the interface and will be used to describe methods 
   // that the implementing scripts need to have
public interface IdataPersistence 
{
   //load data only cares about reading the data
    void LoadData(GameData data); 
     
     //when we save data, this allows implementing script to modify data
     void SaveData (ref GameData data);
}

    