using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public OverlayLoader loader;

    private bool isInventoryOpen = false;

    public Text label;
    public bool charaSelect;

    public bool doPartPreferences;
    public bool showPartPreferences;
    public bool usePrices;
    private bool chatting  = false;

//private TypeStates typestate;

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
        // Player player = Game.GetPlayer();

        if (charaSelect)
        {
            //clear player's character
            Game.GetPlayer().SetPlayerCharacter("");

            // RandomiseFaceParts();

            GetComponentInChildren<Faces>().UpdateMenuFaces();

            RefreshTextDisplay("");
        }
        else
        {
            //set player's character
            Game.GetPlayer().SetPlayerCharacter("1");

            //StartNewDay();
            //Debug.Log("dffdfd");
        }

        //StartCoroutine(OverlayLoader.LoadSceneCo("DialoguePanel"));

         RandomiseFaceParts( Game.GetPartList(), Game.GetCharacterList());
    }

    public void RandomiseFaceParts(List<FacePart> faceParts, List<Character> characters)
    {
        List<string> shapeList = new List<string>(); // new list for Shape
        List<int> rShapeList = Common.GetRandomIntList(4, 4);
        //List<PartEyes> eyesList = new List<PartEyes>(); // new list for Eyes

        //List<int> rEyeList = Common.GetRandomIntList(4, 4);
        //   List<int> rNoseList = Common.GetRandomIntList(4, 4);
        //  List<int> rMouthList = Common.GetRandomIntList(4, 4);

        //  faceParts[rEyeList[0] + 4].GetPartName();
        //  faceParts[rNoseList[0] + 8].GetPartName();
        //  faceParts[rMouthList[0] + 12].GetPartName();

        for (int i = 0; i < 4; i++)
        {
            string randomisedShapeList = faceParts[rShapeList[i]].GetPartName();//This return a string value 
            shapeList.Add(randomisedShapeList); //THIS DON WORK.... string cant covert to class!?!?!?!?

            //characters[i].SetShape(rShapeList[i] as PartShape);//set random values in characters

            //characters[i].SetEyes(eyesList[i]);
            //characters[i].SetNose(faceParts[rNoseList[i]] as PartNose);
            //characters[i].SetMouth(faceParts[rMouthList[i]] as PartMouth);
        }
    }

    void Update()
    {
        //detect inventory key
        // if (Input.GetKeyDown(KeyCode.Mouse0)) ToggleInventory();
        //  detect inventory key
        // if (Input.GetMouseButtonDown(0)) ToggleInventory();

        if (Input.GetMouseButtonDown(0)) //if !isChatting
        {
            int input;

            //parse input into integer
            // if (int.TryParse(Input.inputString, out inputInt))
            // {
            //     // typeState.HandleInput(inputInt); //dont have typeState and inputInt
            // }
        }
    }

    //public void SetTypeStates(TypeStates aState, params string[] paramList)
    //{
    //    typestate = aState;
    //    Common.DebugLog("SetTypeStates " + typestate);
    //    typestate.InitialiseStates(this, paramList);
    //}

    public void UpdateFaces()
    {
        GetComponentInChildren<Faces>().UpdateMenuFaces();
    }

    public void RefreshTextDisplay(string lastText = "")
    {
        Player player = Game.GetPlayer();
        int day = player.GetDay();

        if (day > 0)
        {
            // label.Text = "Day" + day;

            // if (doPartPreferences)
            // {
            //     if (usePrices)
            // }
        }
    }

    public void ChatState(bool isChatting)
    {
        chatting = isChatting;
    }


    // private void ToggleInventory()
    //     {
    //         if (isInventoryOpen)
    //         {
    //             //close inventory
    //             StartCoroutine(OverlayLoader.UnLoadSceneCo("InventoryHUD"));

    //             isInventoryOpen = false;
    //         }
    //         else
    //         {
    //             //open inventory
    //             StartCoroutine(OverlayLoader.LoadSceneCo("InventoryHUD"));

    //             isInventoryOpen = true;
    //         }
    //     }
}
