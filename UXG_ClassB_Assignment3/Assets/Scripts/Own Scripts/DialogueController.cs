using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueController : MonoBehaviour
{
    public TextMeshProUGUI dialogueTextBox;
    public TextMeshProUGUI nameTextBox;

    public Button faceButton;
    public Button eyesButton;
    public Button noseButton;
    public Button mouthButton;

    // Update is called once per frame
    void Update()
    {
        if (ChoiceScript.ChoiceMade == 1)
        {
            nameTextBox.text = "Qing";
            dialogueTextBox.text = "Hi I'm Qing. Do you want my face, eyes, nose or mouth?";
        }

        if (ChoiceScript.ChoiceMade == 2)
        {
            nameTextBox.text = "Seki";
            dialogueTextBox.text = "HEY YOU! I'm Seki. What do you want from me? My face, eyes, nose or mouth?";
        }

        if (ChoiceScript.ChoiceMade == 3)
        {
            nameTextBox.text = "Azure";
            dialogueTextBox.text = "Swasdi. My name is Azure. Do you want my face, eyes, nose or mouth?";
        }
    }
}
