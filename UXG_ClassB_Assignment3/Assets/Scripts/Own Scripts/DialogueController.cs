using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogueController : MonoBehaviour
{
    public TextMeshProUGUI dialogueTextBox;
    public TextMeshProUGUI nameTextBox;

    public static string tradingValue;
    public static string tradingCharacter;

    public static bool isDialogue;

    // Update is called once per frame
    void Start()
    {
        if (ChoiceScript.ChoiceMade == 1)
        {
            tradingCharacter = "Qing";

            nameTextBox.text = "Qing";
            dialogueTextBox.text = "Hi I'm Qing. Do you want my face, eyes, nose or mouth?";
        }

        if (ChoiceScript.ChoiceMade == 2)
        {
            tradingCharacter = "Seki";

            nameTextBox.text = "Seki";
            dialogueTextBox.text = "HEY YOU! I'm Seki. What do you want from me? My face, eyes, nose or mouth?";
        }

        if (ChoiceScript.ChoiceMade == 3)
        {
            tradingCharacter = "Azure";

            nameTextBox.text = "Azure";
            dialogueTextBox.text = "Swasdi. My name is Azure. Do you want my face, eyes, nose or mouth?";
        }
    }

    public void FaceButton()
    {
        tradingValue = "Face";
        dialogueTextBox.text = "Face it is!";
    }
    public void EyeButton()
    {
        tradingValue = "Eyes";
        dialogueTextBox.text = "Eyes it is!";
    }
    public void NoseButton()
    {
        tradingValue = "Nose";
        dialogueTextBox.text = "Nose it is!";
    }
    public void MouthButton()
    {
        tradingValue = "Mouth";
        dialogueTextBox.text = "Mouth it is!";
    }

    public void BackToMainButton()
    {
        isDialogue = false;
        StartCoroutine(OverlayLoader.UnLoadSceneCo("DialoguePanel"));
    }
}
