using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InventoryDemo
{
    public static class Game
    {
        private static PlayerController player;
        private static RoomController currentRoom;
        private static InventoryController inventoryController;

        private static OrbLocation orbLocation;

        public static void InitializeGameData()
        {
            //start orb at pedestal 1
            orbLocation = OrbLocation.PEDESTAL_1;
        }

        public static PlayerController GetPlayer()
        {
            //get player controller
            return player;
        }

        public static void SetPlayer(PlayerController aPlayer)
        {
            //set player controller
            player = aPlayer;
        }

        public static RoomController GetCurrentRoom()
        {
            //get room controller
            return currentRoom;
        }

        public static void SetCurrentRoom(RoomController aRoom)
        {
            //set room controller
            currentRoom = aRoom;
        }

        public static void SetInventory(InventoryController aInventoryController)
        {
            //set inventory controller
            inventoryController = aInventoryController;
        }

        public static void UpdateOrbLocation()
        {
            //refresh inventory display if open
            if (inventoryController != null) inventoryController.RefreshInventory();

            //refresh player orb display
            player.RefreshOrbDisplay();
        }

        public static OrbLocation GetOrbLocation()
        {
            //get orb location, only 1 current location
            return orbLocation;
        }

        public static void SetOrbLocation(OrbLocation aLoc)
        {
            //set orb location, only 1 current location
            orbLocation = aLoc;
        }
    }

    public enum OrbLocation
    {
        PLAYER,
        PEDESTAL_1,
        PEDESTAL_2,
        PEDESTAL_3
    }
}