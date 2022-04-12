using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LikeListController : MonoBehaviour
{
  /*  List<FacePart> faceParts;

    public static List<string> likeListParts = new List<string>();

    List<int> randomLikeParts = new List<int>();

    public static string QingLike, SekiLike, AzureLike;

    private void Awake()
    {
        faceParts = Game.GetPartList();
    }

    private void Start()
    {
        for (int i = 0; i < faceParts.Count; i++)
        {
            likeListParts.Add(faceParts[i].GetPartName());
        }
    }

   

    /* private int one;
     private int two;
     private int three;
     //private int four;
     //private int five;
     //private int six;

     private List<FacePart> slapfaces;

     private string charaOneLike;
     private string charaOneDislike;
     //private string charaTwoLike;
     //private string charaTwoDislike;
     //private string charaThreeLike;
     //private string charaThreeDislike;

     public List<Character> charas;

     private void Awake()
     {
         charas = Game.GetCharacterList();
         slapfaces = Game.GetPartList();
         GetParts();
     }

     private void Update()
     {

     }

     public void Preferences()
     {
         one = Random.Range(0, 15);
         two = Random.Range(0, 15);
         three = Random.Range(0, 15);
         //four = Random.Range(0, 15);
         //five = Random.Range(0, 15);
         //six = Random.Range(0, 15);

         if (two == one)
         {
             Debug.Log("change 2");
             two = Random.Range(0, 15);
         }

         if (three == two && three == one)
         {
             Debug.Log("change 3");
             three = Random.Range(0, 15);
         }

         //if (four == three && four == two && four == one)
         //{
         //    Debug.Log("change 4");
         //    four = Random.Range(0, 15);
         //}

         //if (five == four && five == three && five == two && five == one)
         //{
         //    Debug.Log("change 5");
         //    five = Random.Range(0, 15);
         //}

         //if (six == five && six == four && six == three && six == two && six == one)
         //{
         //    Debug.Log("change 6");
         //    six = Random.Range(0, 15);
         //}

     }

     public void GetParts()
     {

         charaOneLike = slapfaces[one].GetAssetName();

         for (int i = 0; i < 4; i++)
         {
             Preferences();
             Debug.Log("getting parts");
             charas[i].SetLikeList(charaOneLike);
             charas[i].SetDislikeList(charaOneDislike);
         }

         charaOneDislike = slapfaces[two].GetAssetName();

     }*/
}
