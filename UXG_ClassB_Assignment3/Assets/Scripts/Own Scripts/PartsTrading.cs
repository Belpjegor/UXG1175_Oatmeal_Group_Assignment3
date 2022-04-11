using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PartsTrading
{
    public static List<string> tradingCharacter;
    public static List<string> tradingValue = new List<string> { "Face", "Eyes", "Nose", "Mouth" };

    public static List<string> GetTradingChara(List<Character> tradingCharaters)
    {
        List<string> givenList = new List<string>();

        foreach (Character chara in tradingCharaters)
        {
            if (chara != tradingCharaters[0])
            {
                givenList.Add(chara.GetName());
            }
        }

        return givenList;
    }

    public static string GetTradingChara(int value)
    {
        return tradingValue[value];
    }
}
