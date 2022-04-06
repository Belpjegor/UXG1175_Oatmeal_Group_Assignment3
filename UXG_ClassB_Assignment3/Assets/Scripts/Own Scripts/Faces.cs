using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Faces : MonoBehaviour
{
    public List<GameObject> facelist;

    public void UpdateMenuFaces()
    {
        List<Character> charaList = Game.GetCharacterList();
        Player player = Game.GetPlayer();

        for (int i = 0; i < facelist.Count; i++)
        {
            UpdateEveryFace(facelist[i], charaList[i], player.GetPlayerCharacter() == charaList[i].GetRefId());
        }
    }

    private void UpdateEveryFace(GameObject face, Character chara, bool isPlayer)
    {
        //character name
        face.GetComponentInChildren<Text>().text = isPlayer ? "You" : chara.GetName();

        Common.DebugLog("UpdateEveryFace" + chara.GetName());
        face.GetComponentInChildren<CanvasFaceScript>().SetCharaFace(chara);
    }
}
