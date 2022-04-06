using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trading : MonoBehaviour
{
    private Main mainScript;
    private Dictionary<int, PartType> optionList;

    private string tradingCharaRefID;

    public void StartIntialisingState(Main mScript, params string[] paramList)
    {
        mainScript = mScript;
        tradingCharaRefID = paramList[0];
    }

    public void HandleInput(int inputA)
    {
        switch (inputA)
        {
            case 9:
            {
                //refresh
                mainScript.RefreshTextDisplay("Wait awhile.");
            }
            break;

            case 8:
            {
                //chatting
                Character tradeChara = Game.GetCharacter(tradingCharaRefID);
                // mainScript.SetState(true); //no SetState (could be a different name)
                
                AssetManager.LoadUIAsset("DialoguePanel", Vector3.zero, mainScript.transform.parent, (panel) =>
                {
                    // panel.GetComponent<DialoguePanel>().SetDialogue(tradeChara, mainScript.GenerateParts(tradeChara), mScript); //mSciript not in context??
                    panel.GetComponent<RectTransform>().localPosition = Vector3.zero;
                });
                mainScript.RefreshTextDisplay(string.Format("You chat with {0}.", tradeChara.GetName()));
                break;
            }

            case 0:
            {
                //go back
                // mainScript.SetTypeStates(new MainState());
                mainScript.RefreshTextDisplay("");
            }
            break;

            // default:  //error: Control cannot fall out of switch from final case label ('default:')
            // {
            //     if (optionList.ContainsKey(inputA))
            //     {
            //         mainScript.SetTypeStates(new ConfirmState(), tradingCharaRefID, optionList[inputA].ToString());
            //         mainScript.RefreshTextDisplay("");
            //     }
            // }
        }
    }
}
