using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChoiceScript : MonoBehaviour
{
    public TextMeshProUGUI TextBox;
    public GameObject ChoiceQing;
    public GameObject ChoiceSeki;
    public GameObject ChoiceAzure;

    public GameObject dialogueBG;
    public GameObject helloText;
    public GameObject nextDayButton;

    public GameObject player;
    public GameObject qing;
    public GameObject seki;
    public GameObject azure;

    public static int ChoiceMade;

    public void QingChoiceSelection()
    {
        StartCoroutine(OverlayLoader.LoadSceneCo("DialoguePanel"));

        player.transform.position = new Vector2(-508f,-83f);
        qing.transform.position = new Vector2(-312f, -83f);
        dialogueBG.SetActive(true);

        helloText.SetActive(false);
        nextDayButton.SetActive(false);
        seki.SetActive(false);
        azure.SetActive(false);

        ChoiceMade =0;

        ChoiceQing.SetActive(false);
        ChoiceSeki.SetActive(false);
        ChoiceAzure.SetActive(false);

        DialogueController.isDialogue = true;
    }

    public void SekiChoiceSelection()
    {
        StartCoroutine(OverlayLoader.LoadSceneCo("DialoguePanel"));

        player.transform.position = new Vector2(-508f, -83f);
        seki.transform.position = new Vector2(272f, 442f);
        dialogueBG.SetActive(true);

        helloText.SetActive(false);
        nextDayButton.SetActive(false);
        qing.SetActive(false);
        azure.SetActive(false);

        ChoiceMade = 1;

        ChoiceQing.SetActive(false);
        ChoiceSeki.SetActive(false);
        ChoiceAzure.SetActive(false);

        DialogueController.isDialogue = true;
    }

    public void AzureChoiceSelection()
    {
        StartCoroutine(OverlayLoader.LoadSceneCo("DialoguePanel"));

        player.transform.position = new Vector2(-508f, -83f);
        azure.transform.position = new Vector2(-288f, 445f);
        dialogueBG.SetActive(true);

        helloText.SetActive(false);
        nextDayButton.SetActive(false);
        seki.SetActive(false);
        qing.SetActive(false);

        ChoiceMade = 2;

        ChoiceQing.SetActive(false);
        ChoiceSeki.SetActive(false);
        ChoiceAzure.SetActive(false);

        DialogueController.isDialogue = true;
    }

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (DialogueController.isDialogue == false)
        {
            player.transform.position = new Vector2(2.16f, 0.57f);
            qing.transform.position = new Vector2(2.16f, 0.57f);
            seki.transform.position = new Vector2(2.16f, 0.57f);
            azure.transform.position = new Vector2(2.16f, 0.57f);
            dialogueBG.SetActive(false);

            helloText.SetActive(true);
            nextDayButton.SetActive(true);
            player.SetActive(true);
            seki.SetActive(true);
            qing.SetActive(true);
            azure.SetActive(true);

            ChoiceQing.SetActive(true);
            ChoiceSeki.SetActive(true);
            ChoiceAzure.SetActive(true);
        }
    }
}
