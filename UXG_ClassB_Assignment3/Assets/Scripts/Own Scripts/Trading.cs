using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Trading : MonoBehaviour
{
    //public static List<Character> characters;
    public LikeListController prefControl;

    public TextMeshProUGUI LikeTextBox;
    public TextMeshProUGUI dislikeBox;

    void Start()
    {
        //characters = Game.GetCharacterList();
        //charas.GetLikeList();
        //charas.GetDislikeList();
    }

    public static void ItemTrading(List<Character> characters)
    {
        FacePart tradingPlayerItem;
        FacePart tradingCharacterItem;

        if (ChoiceScript.ChoiceMade == 0)
        {
            if (PartsTrading.tradingItem == "Face")
            {
                tradingPlayerItem = characters[0].GetShape();
                tradingCharacterItem = characters[1].GetShape();

                characters[0].SetShape(tradingCharacterItem as PartShape);
                characters[1].SetShape(tradingPlayerItem as PartShape);
            }
            else if (PartsTrading.tradingItem == "Eyes")
            {
                tradingPlayerItem = characters[0].GetEyes();
                tradingCharacterItem = characters[1].GetEyes();

                characters[0].SetEyes(tradingCharacterItem as PartEyes);
                characters[1].SetEyes(tradingPlayerItem as PartEyes);
            }
            else if (PartsTrading.tradingItem == "Nose")
            {
                tradingPlayerItem = characters[0].GetNose();
                tradingCharacterItem = characters[1].GetNose();

                characters[0].SetNose(tradingCharacterItem as PartNose);
                characters[1].SetNose(tradingPlayerItem as PartNose);
            }
            else if (PartsTrading.tradingItem == "Mouth")
            {
                tradingPlayerItem = characters[0].GetMouth();
                tradingCharacterItem = characters[1].GetMouth();

                characters[0].SetMouth(tradingCharacterItem as PartMouth);
                characters[1].SetMouth(tradingPlayerItem as PartMouth);
            }
        }

        if (ChoiceScript.ChoiceMade == 1)
        {
            if (PartsTrading.tradingItem == "Face")
            {
                tradingPlayerItem = characters[0].GetShape();
                tradingCharacterItem = characters[2].GetShape();

                characters[0].SetShape(tradingCharacterItem as PartShape);
                characters[2].SetShape(tradingPlayerItem as PartShape);
            }
            else if (PartsTrading.tradingItem == "Eyes")
            {
                tradingPlayerItem = characters[0].GetEyes();
                tradingCharacterItem = characters[2].GetEyes();

                characters[0].SetEyes(tradingCharacterItem as PartEyes);
                characters[2].SetEyes(tradingPlayerItem as PartEyes);
            }
            else if (PartsTrading.tradingItem == "Nose")
            {
                tradingPlayerItem = characters[0].GetNose();
                tradingCharacterItem = characters[2].GetNose();

                characters[0].SetNose(tradingCharacterItem as PartNose);
                characters[2].SetNose(tradingPlayerItem as PartNose);
            }
            else if (PartsTrading.tradingItem == "Mouth")
            {
                tradingPlayerItem = characters[0].GetMouth();
                tradingCharacterItem = characters[2].GetMouth();

                characters[0].SetMouth(tradingCharacterItem as PartMouth);
                characters[2].SetMouth(tradingPlayerItem as PartMouth);
            }
        }

        if (ChoiceScript.ChoiceMade == 2)
        {
            if (PartsTrading.tradingItem == "Face")
            {
                tradingPlayerItem = characters[0].GetShape();
                tradingCharacterItem = characters[3].GetShape();

                characters[0].SetShape(tradingCharacterItem as PartShape);
                characters[3].SetShape(tradingPlayerItem as PartShape);
            }
            else if (PartsTrading.tradingItem == "Eyes")
            {
                tradingPlayerItem = characters[0].GetEyes();
                tradingCharacterItem = characters[3].GetEyes();

                characters[0].SetEyes(tradingCharacterItem as PartEyes);
                characters[3].SetEyes(tradingPlayerItem as PartEyes);
            }
            else if (PartsTrading.tradingItem == "Nose")
            {
                tradingPlayerItem = characters[0].GetNose();
                tradingCharacterItem = characters[3].GetNose();

                characters[0].SetNose(tradingCharacterItem as PartNose);
                characters[3].SetNose(tradingPlayerItem as PartNose);
            }
            else if (PartsTrading.tradingItem == "Mouth")
            {
                tradingPlayerItem = characters[0].GetMouth();
                tradingCharacterItem = characters[3].GetMouth();

                characters[0].SetMouth(tradingCharacterItem as PartMouth);
                characters[3].SetMouth(tradingPlayerItem as PartMouth);
            }
        }
    }
}
