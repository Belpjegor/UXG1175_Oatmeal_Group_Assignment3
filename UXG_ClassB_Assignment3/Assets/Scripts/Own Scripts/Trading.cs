using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Trading : MonoBehaviour
{
    List<Character> charas;
    public LikeListController prefControl;

    public TextMeshProUGUI LikeTextBox;
    public TextMeshProUGUI dislikeBox;

    void Start()
    {
        charas = Game.GetCharacterList();
        //charas.GetLikeList();
        //charas.GetDislikeList();

        for (int i = 0; i < 4; i++)
        {
            Debug.Log("show like");
            prefControl.Preferences();
            LikeTextBox.text = charas[i].GetLikeList();
            Debug.Log("show dislike");
            dislikeBox.text = charas[i].GetDislikeList();
        }

        //LikeTextBox.text = charas.GetLikeList();
        //disLikeTextBox.text = charas.GetDislikeList();
    }
    private void Update()
    {
        ItemTrading();
    }

    void ItemTrading()
    {
        if (ChoiceScript.ChoiceMade == 0 && PartsTrading.tradingItem == "Face")
        {
            Debug.Log(PartsTrading.tradingCharacter[0] + " "+ PartsTrading.tradingItem);
        }
    }
}
