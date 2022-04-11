using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogueController : MonoBehaviour
{
    List<Character> characters;
    public TextMeshProUGUI dialogueTextBox;
    public TextMeshProUGUI nameTextBox;

    public static bool isDialogue;

    // Update is called once per frame
    void Start()
    {
        characters = Game.GetCharacterList();
        PartsTrading.tradingCharacter = PartsTrading.GetTradingChara(characters);

        if (ChoiceScript.ChoiceMade == 0)
        {
            nameTextBox.text = PartsTrading.tradingCharacter[0];

            dialogueTextBox.text = "Hi I'm Qing. Do you want my face, eyes, nose or mouth?";
        }

        if (ChoiceScript.ChoiceMade == 1)
        {

            nameTextBox.text = PartsTrading.tradingCharacter[1];
            dialogueTextBox.text = "HEY YOU! I'm Seki. What do you want from me? My face, eyes, nose or mouth?";
        }

        if (ChoiceScript.ChoiceMade == 2)
        {

            nameTextBox.text = PartsTrading.tradingCharacter[2];
            dialogueTextBox.text = "Swasdi. My name is Azure. Do you want my face, eyes, nose or mouth?";
        }

        foreach(string v in PartsTrading.tradingCharacter)
        {
            Debug.Log(v);
        }
    }

     string DialogueToUse(int value)
    {
        List<string> dialogueText = new List<string>();

        dialogueText.Add("Hi I'm " + PartsTrading.tradingCharacter[value] + " . What can I trade with you today?");

        dialogueText.Add(PartsTrading.tradingCharacter[value] + " is my name. Do you want to trade with my " + PartsTrading.GetTradingChara(0) + ", " +
                PartsTrading.GetTradingChara(1) + ", " + PartsTrading.GetTradingChara(2) + " or " + PartsTrading.GetTradingChara(3) + " ?");

        dialogueText.Add("My name is " + PartsTrading.tradingCharacter[value] + " . What do you want to trade?");

        dialogueText.Add("HEY YOU! I'm " + PartsTrading.tradingCharacter[value] + " . What do you want from me?" + PartsTrading.GetTradingChara(0) + ", " +
                PartsTrading.GetTradingChara(1) + ", " + PartsTrading.GetTradingChara(2) + " or " + PartsTrading.GetTradingChara(3) + " ?");

        return null;
    }
}
