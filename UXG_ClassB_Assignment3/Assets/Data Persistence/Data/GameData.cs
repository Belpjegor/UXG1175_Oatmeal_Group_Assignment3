using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class GameData
{
   public int saveFaceParts;

   //value in this constructor is the default values
   // game starts with no loading data
   public GameData()
   {
       this.saveFaceParts = 0;
   }
   


}
