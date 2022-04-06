using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmState : MonoBehaviour
{
    private Main mScript;
    private Dictionary<int, PartType> optionList;

    private string tradingCharaRefID;
    private PartType tradingPartTypes;

    public string GetStateDisplay()
    {
        Character tradeChara = Game.GetCharacter(tradingCharaRefID);
        Character playersChara = Game.GetPlayerCharacter();
        optionList = new Dictionary<int, PartType>();

        string displayString = "";

        //preferences here
        // PartsTrading playerPart = playersChara.GetTradePartbyType(tradingPartTypes);
        // PartsTrading charaPart = tradeChara.GetTradePartbyType(tradingPartTypes);

        if (mScript.doPartPreferences)
        {
            displayString += tradeChara.GetName() + ": ";

            // displayString += "\n\"" + mScript.GetPlayerPart(tradeChara, playerPart) + "\"";
            // displayString += "\n\"" + mScript.GetOwnPart(tradeChara, charaPart) + "\"\n\r";
        }

        //confirm
        // displayString += string.Format("Trade your {1} for {0}'s {2}?\n", tradeChara.GetName(), playerPart.GetDisplayName(), tradeChara.GetTradePartbyType(tradingPartTypes).GetDisplayName());

        displayString += "\n1 - Yes";
        displayString += "\n0 - No";

        return displayString;
    }

    public void HandleInput(int inputA)
    {
        switch (inputA)
        {
            case 0:
            {
                //back to trading
                // mScript.SetState(new Trading(), tradingCharaRefID);
                mScript.RefreshTextDisplay();
            }
            break;

            // case 1: //Control cannot fall out of switch from final case label ('case 1:')
            // {
            //     //trade selected part
            //     string tradingResult = mScript.Trade(tradingPartTypes, tradingCharaRefID);

            //     mScript.SetState(new Trading(), tradingCharaRefID);
            //     mScript.RefreshTextDisplay(tradingResult);
            // }
        }
    }

    public void InitialiseStates(Main aScript, params string[] paramList)
    {
        mScript = aScript;

        tradingCharaRefID = paramList[0];
        tradingPartTypes = Common.ParseEnum<PartType>(paramList[1]);
    }
}
