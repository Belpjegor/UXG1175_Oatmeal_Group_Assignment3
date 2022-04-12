using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueButtonController : MonoBehaviour
{
    public TextMeshProUGUI dialogueTextBox;

    public void FaceButton()
    {
        PartsTrading.tradingItem = PartsTrading.tradingValue[0];
        dialogueTextBox.text = PartsTrading.GetTradingChara(0) + " it is!";

        Trading.ItemTrading();
    }
    public void EyeButton()
    {
        PartsTrading.tradingItem = PartsTrading.tradingValue[1];
        dialogueTextBox.text = PartsTrading.GetTradingChara(1) + " it is!";

        Trading.ItemTrading();
    }
    public void NoseButton()
    {
        PartsTrading.tradingItem = PartsTrading.tradingValue[2];
        dialogueTextBox.text = PartsTrading.GetTradingChara(2) + " it is!";

        Trading.ItemTrading();
    }
    public void MouthButton()
    {
        PartsTrading.tradingItem = PartsTrading.tradingValue[3];
        dialogueTextBox.text = PartsTrading.GetTradingChara(3) + " it is!";

        Trading.ItemTrading();
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
