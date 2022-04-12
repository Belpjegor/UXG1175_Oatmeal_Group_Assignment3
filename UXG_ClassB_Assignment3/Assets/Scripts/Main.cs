using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main : MonoBehaviour, IdataPersistence
{
    public OverlayLoader loader;
    public int saveFaceParts;

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
    }

     public void LoadData(GameData data)
    {
        this.saveFaceParts = data.saveFaceParts;
    }

    public void SaveData(ref GameData data)
    {
        data.saveFaceParts = this.saveFaceParts;
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

    private void OnApplicationQuit()
    {
        SaveLoad.Load();
    }
    
}
