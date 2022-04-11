using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueButtonController : MonoBehaviour
{
    public TextMeshProUGUI dialogueTextBox;

    public void FaceButton()
    {
        dialogueTextBox.text = PartsTrading.GetTradingChara(0) + " it is!";
    }
    public void EyeButton()
    {
        dialogueTextBox.text = PartsTrading.GetTradingChara(1) + " it is!";
    }
    public void NoseButton()
    {
        dialogueTextBox.text = PartsTrading.GetTradingChara(2) + " it is!";
    }
    public void MouthButton()
    {
        dialogueTextBox.text = PartsTrading.GetTradingChara(3) + " it is!";
    }
    public void BackToMainButton()
    {
        DialogueController.isDialogue = false;
        StartCoroutine(OverlayLoader.UnLoadSceneCo("DialoguePanel"));
    }
}
