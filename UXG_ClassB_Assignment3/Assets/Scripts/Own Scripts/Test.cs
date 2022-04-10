using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Button nextDayButton;

    List<Character> characters;

    List<FacePart> partShape;
    List<FacePart> partEyes;
    List<FacePart> partNose;
    List<FacePart> partMouth;

    List<FacePart> randomPartShape;
    List<FacePart> randomPartEyes;
    List<FacePart> randomPartNose;
    List<FacePart> randomPartMouth;

    private void Awake()
    {
        characters = Game.GetCharacterList();
    }

    private void Start()
    {
        Randomising();
        SetRandomValueIntoCharacters();
    }

    public void Randomising()
    {
        partShape = Game.GetPartListByType(PartType.SHAPE);
        partEyes = Game.GetPartListByType(PartType.EYES);
        partNose = Game.GetPartListByType(PartType.NOSE);
        partMouth = Game.GetPartListByType(PartType.MOUTH);

        randomPartShape = Common.GetRandomList(partShape, partShape.Count);
        randomPartEyes = Common.GetRandomList(partEyes, partEyes.Count);
        randomPartNose = Common.GetRandomList(partNose, partNose.Count);
        randomPartMouth = Common.GetRandomList(partMouth, partMouth.Count);
    }

    void SetRandomValueIntoCharacters()
    {
        for (int i=0; i < characters.Count; i++)
        {
            if (characters[i].GetShape() == null)
            {
                characters[i].SetShape(randomPartShape[i] as PartShape);
            }

            if (characters[i].GetEyes() == null)
            {
                characters[i].SetEyes(randomPartEyes[i] as PartEyes);
            }

            if (characters[i].GetNose() == null)
            {
                characters[i].SetNose(randomPartNose[i] as PartNose);
            }

            if (characters[i].GetMouth() == null)
            {
                characters[i].SetMouth(randomPartMouth[i] as PartMouth);
            }
        }
    }

    public void NextDayButton()
    {
        Randomising();
        for (int i = 0; i < characters.Count; i++)
        {
                characters[i].SetShape(randomPartShape[i] as PartShape);

                characters[i].SetEyes(randomPartEyes[i] as PartEyes);

                characters[i].SetNose(randomPartNose[i] as PartNose);
 
                characters[i].SetMouth(randomPartMouth[i] as PartMouth);  
        }
    }
}
