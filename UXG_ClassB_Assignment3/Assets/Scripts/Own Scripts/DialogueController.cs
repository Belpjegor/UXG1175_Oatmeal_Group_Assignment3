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

    public TextMeshProUGUI likeTextBox;
    public TextMeshProUGUI dislikeTextBox;

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
            likeTextBox.text = MainController.likeItemPartsQ + MainController.QingLike;
            dislikeTextBox.text = MainController.dislikeItemPartsQ + MainController.QingDislike;
            dialogueTextBox.text = DialogueToUse(0);
        }

        if (ChoiceScript.ChoiceMade == 1)
        {
            nameTextBox.text = Seki;
            likeTextBox.text = MainController.likeItemPartsS + MainController.SekiLike;
            dislikeTextBox.text = MainController.dislikeItemPartsS + MainController.SekiDislike;
            dialogueTextBox.text = DialogueToUse(1);
        }

        if (ChoiceScript.ChoiceMade == 2)
        {
            nameTextBox.text = Azure;
            likeTextBox.text = MainController.likeItemPartsA + MainController.AzureLike;
            dislikeTextBox.text = MainController.dislikeItemPartsA + MainController.AzureDislike;
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
            dialogueText.Add("Good day young one. I'm " + tchara + ". You want to trade anything with me?");

            dialogueText.Add("Hi young one. Your kind grandpa " +tchara + "is here to trade something with you today.");

            dialogueText.Add("Young one I'm " + tchara + ". Such a good weather to trade today.");
        }

        if (value == 2)
        {
            tchara = Azure;
            dialogueText.Add("Hi me? Oh. I'm " + tchara + ". What do you want to trade? I have to go back and rush my 1175 assignment. :D");

            dialogueText.Add("I'm " + tchara + ". Quickly choose something to trade. I'm late for my 1175 assignment submission!");

            dialogueText.Add("Hi... I'm " + tchara + ". Just choose anything you like... I'm failing my 1175 class anyway...");
        }


        return dialogueText[randomIndex];
    }
}
