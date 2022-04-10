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
        qing.transform.position = new Vector2(-619f, -120f);
        dialogueBG.SetActive(true);

        helloText.SetActive(false);
        nextDayButton.SetActive(false);
        player.SetActive(false);
        seki.SetActive(false);
        azure.SetActive(false);

        ChoiceMade = 1;
    }

    public void SekiChoiceSelection()
    {
        StartCoroutine(OverlayLoader.LoadSceneCo("DialoguePanel"));
        seki.transform.position = new Vector2(-58f, 407f);
        dialogueBG.SetActive(true);

        helloText.SetActive(false);
        nextDayButton.SetActive(false);
        player.SetActive(false);
        qing.SetActive(false);
        azure.SetActive(false);

        ChoiceMade =2;
    }

    public void AzureChoiceSelection()
    {
        StartCoroutine(OverlayLoader.LoadSceneCo("DialoguePanel"));
        azure.transform.position = new Vector2(-618f, 411f);
        dialogueBG.SetActive(true);

        helloText.SetActive(false);
        nextDayButton.SetActive(false);
        player.SetActive(false);
        seki.SetActive(false);
        qing.SetActive(false);

        ChoiceMade =3;
    }

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if  (ChoiceMade >=1){
            ChoiceQing.SetActive (false);
            ChoiceSeki.SetActive (false);
            ChoiceAzure.SetActive (false);
        } 
    }
}
