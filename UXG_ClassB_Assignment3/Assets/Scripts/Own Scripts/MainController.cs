using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainController : MonoBehaviour
{
    public Button nextDayButton;

    List<Character> characters;

    public static List<FacePart> partShape;
    public static List<FacePart> partEyes;
    public static List<FacePart> partNose;
    public static List<FacePart> partMouth;

    List<FacePart> randomPartShape;
    List<FacePart> randomPartEyes;
    List<FacePart> randomPartNose;
    List<FacePart> randomPartMouth;

    //Likelist Stuff
    List<FacePart> faceParts;
    public static string likeItemPartsQ;
    public static string likeItemPartsS;
    public static string likeItemPartsA;
    public static List<string> likeListParts = new List<string>();
    public static List<int> randomLikeParts = new List<int>();
    public static string QingLike, SekiLike, AzureLike;

    //Dislikelist Stuff
    public static string dislikeItemPartsQ;
    public static string dislikeItemPartsS;
    public static string dislikeItemPartsA;
    public static List<string> dislikeListParts = new List<string>();
    public static List<int> randomDislikeParts = new List<int>();
    public static string QingDislike, SekiDislike, AzureDislike;

    private void Awake()
    {
        characters = Game.GetCharacterList();
        faceParts = Game.GetPartList();
    }

    private void Start()
    {
        for (int i = 0; i < faceParts.Count; i++)
        {
            likeListParts.Add(faceParts[i].GetPartName());
        }

        Randomising();
        SetRandomValueIntoCharacters();
        LikeListRandomising();
        DislikeListRandomising();

        nextDayButton.onClick.AddListener(NextDayButton);
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
        for (int i = 0; i < characters.Count; i++)
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

     public static void LikeListRandomising()
     {
        List<string> newLikeListParts = new List<string>();

        randomLikeParts = Common.GetRandomIntList(15, 3);

        for (int i = 0; i < randomLikeParts.Count; i++)
        {
            newLikeListParts.Add(likeListParts[randomLikeParts[i]]);
        }

        QingLike = newLikeListParts[0];
        SekiLike = newLikeListParts[1];
        AzureLike = newLikeListParts[2];

        if (randomLikeParts[0] >= 0 && randomLikeParts[0] <= 3)
        {
            likeItemPartsQ = "Face: ";
        }
        else if (randomLikeParts[0] >= 4 && randomLikeParts[0] <= 7)
        {
            likeItemPartsQ = "Eyes: ";
        }
        else if (randomLikeParts[0] >= 8 && randomLikeParts[0] <= 11)
        {
            likeItemPartsQ = "Nose: ";
        }
        else if (randomLikeParts[0] >= 12 && randomLikeParts[0] <= 15)
        {
            likeItemPartsQ = "Mouth: ";
        }

        if (randomLikeParts[1] >= 0 && randomLikeParts[1] <= 3)
        {
            likeItemPartsS = "Face: ";
        }
        else if (randomLikeParts[1] >= 4 && randomLikeParts[1] <= 7)
        {
            likeItemPartsS = "Eyes: ";
        }
        else if (randomLikeParts[1] >= 8 && randomLikeParts[1] <= 11)
        {
            likeItemPartsS = "Nose: ";
        }
        else if (randomLikeParts[1] >= 12 && randomLikeParts[1] <= 15)
        {
            likeItemPartsS = "Mouth: ";
        }

        if (randomLikeParts[2] >= 0 && randomLikeParts[2] <= 3)
        {
            likeItemPartsA = "Face: ";
        }
        else if (randomLikeParts[2] >= 4 && randomLikeParts[2] <= 7)
        {
            likeItemPartsA = "Eyes: ";
        }
        else if (randomLikeParts[2] >= 8 && randomLikeParts[2] <= 11)
        {
            likeItemPartsA = "Nose: ";
        }
        else if (randomLikeParts[2] >= 12 && randomLikeParts[2] <= 15)
        {
            likeItemPartsA = "Mouth: ";
        }
    }

    public static void DislikeListRandomising()
    {
        List<string> dislikeListParts = new List<string>();

        randomDislikeParts = Common.GetRandomIntList(15, 3);

        if(CheckSame(randomLikeParts, randomDislikeParts) == true)
        {
            randomDislikeParts = Common.GetRandomIntList(15, 3);
        }
        else
        {
            for (int i = 0; i < randomDislikeParts.Count; i++)
            {
                dislikeListParts.Add(likeListParts[randomDislikeParts[i]]);
            }

            QingDislike = dislikeListParts[0];
            SekiDislike = dislikeListParts[1];
            AzureDislike = dislikeListParts[2];

            foreach(string v in dislikeListParts)
            {
                Debug.Log("Dislike dd " + v);
            }
        }

        if (randomDislikeParts[0] >= 0 && randomDislikeParts[0] <= 3)
        {
            dislikeItemPartsQ = "Face: ";
        }
        else if (randomDislikeParts[0] >= 4 && randomDislikeParts[0] <= 7)
        {
            dislikeItemPartsQ = "Eyes: ";
        }
        else if (randomDislikeParts[0] >= 8 && randomDislikeParts[0] <= 11)
        {
            dislikeItemPartsQ = "Nose: ";
        }
        else if (randomDislikeParts[0] >= 12 && randomDislikeParts[0] <= 15)
        {
            dislikeItemPartsQ = "Mouth: ";
        }

        if (randomDislikeParts[1] >= 0 && randomDislikeParts[1] <= 3)
        {
            dislikeItemPartsS = "Face: ";
        }
        else if (randomDislikeParts[1] >= 4 && randomDislikeParts[1] <= 7)
        {
            dislikeItemPartsS = "Eyes: ";
        }
        else if (randomDislikeParts[1] >= 8 && randomDislikeParts[1] <= 11)
        {
            dislikeItemPartsS = "Nose: ";
        }
        else if (randomDislikeParts[1] >= 12 && randomDislikeParts[1] <= 15)
        {
            dislikeItemPartsS = "Mouth: ";
        }

        if (randomDislikeParts[2] >= 0 && randomDislikeParts[2] <= 3)
        {
            dislikeItemPartsA = "Face: ";
        }
        else if (randomDislikeParts[2] >= 4 && randomDislikeParts[2] <= 7)
        {
            dislikeItemPartsA = "Eyes: ";
        }
        else if (randomDislikeParts[2] >= 8 && randomDislikeParts[2] <= 11)
        {
            dislikeItemPartsA = "Nose: ";
        }
        else if (randomDislikeParts[2] >= 12 && randomDislikeParts[2] <= 15)
        {
            dislikeItemPartsA = "Mouth: ";
        }
    }

    public static bool CheckSame(List<int> Value1, List<int> Value2)
    {
        foreach (int i in Value1)
        {
            foreach (int l in Value2)
            {
                if (i == l)
                {
                    return true;
                }
            }
        }
        return false;
    }

    void NextDayButton()
    {
        Randomising();
        LikeListRandomising();
        DislikeListRandomising();

        for (int i = 0; i < characters.Count; i++)
        {
            characters[i].SetShape(randomPartShape[i] as PartShape);

            characters[i].SetEyes(randomPartEyes[i] as PartEyes);

            characters[i].SetNose(randomPartNose[i] as PartNose);

            characters[i].SetMouth(randomPartMouth[i] as PartMouth);
        }

    }
}
