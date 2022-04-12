using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueButtonController : MonoBehaviour
{
    List<Character> characters;

    public TextMeshProUGUI dialogueTextBox;
    public void Start()
    {
        characters = Game.GetCharacterList();
    }
    public void FaceButton()
    {
        PartsTrading.tradingItem = PartsTrading.tradingValue[0];

        if (ChoiceScript.ChoiceMade == 0)
        { 
            dialogueTextBox.text = PartsTrading.GetTradingChara(0) + DialogueToUseButton(0); 
        }
        else if (ChoiceScript.ChoiceMade == 1)
        {
            dialogueTextBox.text = PartsTrading.GetTradingChara(0) + DialogueToUseButton(1);
        }
        else if (ChoiceScript.ChoiceMade == 2)
        {
            dialogueTextBox.text = PartsTrading.GetTradingChara(0) + DialogueToUseButton(2);
        }

        Trading.ItemTrading(characters);
    }
    public void EyeButton()
    {
        PartsTrading.tradingItem = PartsTrading.tradingValue[1];

        if (ChoiceScript.ChoiceMade == 0)
        {
            dialogueTextBox.text = PartsTrading.GetTradingChara(1) + DialogueToUseButton(0);
        }
        else if (ChoiceScript.ChoiceMade == 1)
        {
            dialogueTextBox.text = PartsTrading.GetTradingChara(1) + DialogueToUseButton(1);
        }
        else if (ChoiceScript.ChoiceMade == 2)
        {
            dialogueTextBox.text = PartsTrading.GetTradingChara(1) + DialogueToUseButton(2);
        }

        Trading.ItemTrading(characters);
    }
    public void NoseButton()
    {
        PartsTrading.tradingItem = PartsTrading.tradingValue[2];

        if (ChoiceScript.ChoiceMade == 0)
        {
            dialogueTextBox.text = PartsTrading.GetTradingChara(2) + DialogueToUseButton(0);
        }
        else if (ChoiceScript.ChoiceMade == 1)
        {
            dialogueTextBox.text = PartsTrading.GetTradingChara(2) + DialogueToUseButton(1);
        }
        else if (ChoiceScript.ChoiceMade == 2)
        {
            dialogueTextBox.text = PartsTrading.GetTradingChara(2) + DialogueToUseButton(2);
        }

        Trading.ItemTrading(characters);
    }
    public void MouthButton()
    {
        PartsTrading.tradingItem = PartsTrading.tradingValue[3];

        if (ChoiceScript.ChoiceMade == 0)
        {
            dialogueTextBox.text = PartsTrading.GetTradingChara(3) + DialogueToUseButton(0);
        }
        else if (ChoiceScript.ChoiceMade == 1)
        {
            dialogueTextBox.text = PartsTrading.GetTradingChara(3) + DialogueToUseButton(1);
        }
        else if (ChoiceScript.ChoiceMade == 2)
        {
            dialogueTextBox.text = PartsTrading.GetTradingChara(3) + DialogueToUseButton(2);
        }

        Trading.ItemTrading(characters);
    }
    public void BackToMainButton()
    {
        DialogueController.isDialogue = false;
        StartCoroutine(OverlayLoader.UnLoadSceneCo("DialoguePanel"));
    }

    string DialogueToUseButton(int value)
    {
        List<string> dialogueButtonText = new List<string>();

        int randomIndex = Random.Range(0, 2);

        if (value == 0)
        {
            dialogueButtonText.Add("traded. Thank you.");

            dialogueButtonText.Add("? Nice trade!");
        }

        if (value == 1)
        {
            dialogueButtonText.Add("traded. Thank you young one.");

            dialogueButtonText.Add("? I always wanted that young one!");
        }

        if (value == 2)
        {
            dialogueButtonText.Add("? Yes. Take whatever and change whatever you want.");

            dialogueButtonText.Add("? Okay... Go ahead...");
        }

        return dialogueButtonText[randomIndex];
    }
}
