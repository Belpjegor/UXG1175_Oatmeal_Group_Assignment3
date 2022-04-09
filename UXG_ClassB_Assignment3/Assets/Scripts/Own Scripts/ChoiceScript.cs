using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceScript : MonoBehaviour
{
  public GameObject TextBox;
  public GameObject ChoiceQing;
  public GameObject ChoiceSeki;
  public GameObject ChoiceAzure;

  public int ChoiceMade;

  public void QingChoiceSelection(){
      TextBox.GetComponent<Text>().text = "Okay do you want my nose, face, left eye, right eye or mouth?";
      ChoiceMade=1;

  }

    public void SekiChoiceSelection(){
      TextBox.GetComponent<Text>().text = "Okay do you want my nose, face, left eye, right eye or mouth?";
      ChoiceMade=2;
  }

    public void AzureChoiceSelection(){
      TextBox.GetComponent<Text>().text = "Okay do you want my nose, face, left eye, right eye or mouth?";
      ChoiceMade=3;
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
