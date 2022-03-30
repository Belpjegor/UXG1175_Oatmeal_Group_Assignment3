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
        List<FacePart> faceParts = Game.GetPartList();
        List<Character> characters = Game.GetCharacterList();
    }

    void RandomiseFaceParts(List<FacePart> faceParts)
    {
        List<int> rShapeList = Common.GetRandomIntList(4, 4);
        List<int> rEyeList = Common.GetRandomIntList(4, 4);
        List<int> rNoseList = Common.GetRandomIntList(4, 4);
        List<int> rMouthList = Common.GetRandomIntList(4, 4);


        faceParts[rShapeList[0]].GetPartName();
        faceParts[rEyeList[0] + 4].GetPartName();
        faceParts[rNoseList[0] + 8].GetPartName();
        faceParts[rMouthList[0] + 12].GetPartName();

        List<Character> characters = Game.GetCharacterList();
      //  characters[0].SetShape(faceParts[rList[0]] as PartShape);
     //   characters[0].SetEyes(faceParts[rList[0]+4] as PartEyes);
    }
}
