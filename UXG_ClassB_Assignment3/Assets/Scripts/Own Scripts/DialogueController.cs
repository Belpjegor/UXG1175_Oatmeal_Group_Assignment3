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
    string Qing, Seki, Azure;
    // Update is called once per frame
    void Start()
    {
        characters = Game.GetCharacterList();
        PartsTrading.tradingCharacter = PartsTrading.GetTradingChara(characters);

        Qing = PartsTrading.tradingCharacter[0];
        Seki = PartsTrading.tradingCharacter[1];
        Azure = PartsTrading.tradingCharacter[2];

        DialogueToUse(0);

        if (ChoiceScript.ChoiceMade == 0)
        {
            nameTextBox.text = Qing;

            dialogueTextBox.text = DialogueToUse(0);
        }

        if (ChoiceScript.ChoiceMade == 1)
        {

            nameTextBox.text = Seki;
            dialogueTextBox.text = DialogueToUse(1);
        }

        if (ChoiceScript.ChoiceMade == 2)
        {
            nameTextBox.text = Azure;
            dialogueTextBox.text = DialogueToUse(2);
        }
    }

     string DialogueToUse(int value)
    {
        List<string> dialogueText = new List<string>();
        string tchara;

        int randomIndex = Random.Range(0, 3);

        if (value == 0)
        {
            tchara = Qing;
            dialogueText.Add("Hi I'm " + tchara + ". What can I trade with you today?");

            dialogueText.Add(tchara + " is my name. Do you want to trade with my " + PartsTrading.GetTradingChara(0) + ", " +
                   PartsTrading.GetTradingChara(1) + ", " + PartsTrading.GetTradingChara(2) + " or " + PartsTrading.GetTradingChara(3) + " ?");

            dialogueText.Add("My name is " + tchara + ". What do you want to trade?");
        }

        if (value == 1)
        {
            tchara = Seki;
            dialogueText.Add("Hi I'm " + tchara + ". 1");

            dialogueText.Add(tchara + " 2 " + PartsTrading.GetTradingChara(0) + ", " +
                   PartsTrading.GetTradingChara(1) + ", " + PartsTrading.GetTradingChara(2) + " or " + PartsTrading.GetTradingChara(3) + " ?");

            dialogueText.Add("My name is " + tchara + ". 3");
        }

        if (value == 2)
        {
            tchara = Azure;
            dialogueText.Add("Hi I'm " + tchara + ". d?");

            dialogueText.Add(tchara + " dd " + PartsTrading.GetTradingChara(0) + ", " +
                   PartsTrading.GetTradingChara(1) + ", " + PartsTrading.GetTradingChara(2) + " or " + PartsTrading.GetTradingChara(3) + " ?");

            dialogueText.Add("My name is " + tchara + ". ddd?");
        }


        return dialogueText[randomIndex];
    }
}
