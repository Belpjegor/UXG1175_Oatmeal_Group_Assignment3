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
    }
    public void EyeButton()
    {
        PartsTrading.tradingItem = PartsTrading.tradingValue[1];
        dialogueTextBox.text = PartsTrading.GetTradingChara(1) + " it is!";
    }
    public void NoseButton()
    {
        PartsTrading.tradingItem = PartsTrading.tradingValue[2];
        dialogueTextBox.text = PartsTrading.GetTradingChara(2) + " it is!";
    }
    public void MouthButton()
    {
        PartsTrading.tradingItem = PartsTrading.tradingValue[3];
        dialogueTextBox.text = PartsTrading.GetTradingChara(3) + " it is!";
    }
    public void BackToMainButton()
    {
        DialogueController.isDialogue = false;
        StartCoroutine(OverlayLoader.UnLoadSceneCo("DialoguePanel"));
    }
}
