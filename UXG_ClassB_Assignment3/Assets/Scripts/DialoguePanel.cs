using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialoguePanel : MonoBehaviour
{
  public Text dialoguText, speakerName;
  public CanvasFaceScript speakerFace;

  private List<string> linelist;
  private int currentIndex;


  public void SetDialogue(Character speakerChar, List<string> aLineList)
  {
      speakerName.text = speakerChar.GetName();
      //speakerFace.SetFace(speakerChar);

      linelist = aLineList;
      currentIndex = 0;
      ShowCurrentLine();
  }

  private void ShowCurrentLine()
  {
      if(linelist.Count > currentIndex)
      {
          dialoguText.text = linelist[currentIndex];
      }
      else
      {
          Destroy(this.gameObject);
      }
      
  }

  public void GoToNextLine()
  {
      currentIndex += 1;
      ShowCurrentLine();
  }



}
