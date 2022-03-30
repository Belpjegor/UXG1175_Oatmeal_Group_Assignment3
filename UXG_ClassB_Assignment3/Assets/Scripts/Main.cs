using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Check if game data has been loaded
        if (!Game.CheckIsLoaded())
        {
            //If not yet loaded, go to LoadScreen to load data
            SceneManager.LoadScene("LoadScreen");
            return;
        }

        //TODO: Game starts here
        Player player = Game.GetPlayer();

        RandomiseFaceParts(Game.GetPartList(), Game.GetCharacterList());

        Debug.Log("dffdfd");
    }

    void RandomiseFaceParts(List<FacePart> faceParts, List<Character> characters)
    {
        List<int> rShapeList = Common.GetRandomIntList(4, 4);
        List<int> rEyeList = Common.GetRandomIntList(4, 4);
        List<int> rNoseList = Common.GetRandomIntList(4, 4);
        List<int> rMouthList = Common.GetRandomIntList(4, 4);

        faceParts[rShapeList[0]].GetPartName();
        faceParts[rEyeList[0] + 4].GetPartName();
        faceParts[rNoseList[0] + 8].GetPartName();
        faceParts[rMouthList[0] + 12].GetPartName();

        for (int fParts = 3; fParts >= 0; fParts--)
        {
            characters[fParts].SetShape(faceParts[rShapeList[fParts]] as PartShape);
            characters[fParts].SetEyes(faceParts[rEyeList[fParts]] as PartEyes);
            characters[fParts].SetNose(faceParts[rNoseList[fParts]] as PartNose);
            characters[fParts].SetMouth(faceParts[rMouthList[fParts]] as PartMouth);
        }
    }
}
