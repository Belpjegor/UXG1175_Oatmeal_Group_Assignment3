using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InventoryDemo
{
    public class Doorway : MonoBehaviour
    {
        public string toRoom;
        public float targetPosX;

        //MonoBehaviour function that triggers when a trigger collider enters
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //check if other collider is player
            if (collision.name == "Player")
            {
                //run function to go to target room and spawn at location
                Game.GetPlayer().GoToRoom(toRoom, targetPosX);
            }
        }
    }
}