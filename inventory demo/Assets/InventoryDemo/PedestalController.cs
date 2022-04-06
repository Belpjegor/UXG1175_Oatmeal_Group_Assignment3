using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InventoryDemo
{
    public class PedestalController : MonoBehaviour, IInteract
    {
        public OrbLocation checkLocation;
        public GameObject orbObject;

        private bool hasOrb; //track if orb is on pedestal

        public void Interact()
        {
            if (hasOrb)
            {
                //give orb to player
                Game.SetOrbLocation(OrbLocation.PLAYER);
                hasOrb = false;
            }
            else if (Game.GetOrbLocation() == OrbLocation.PLAYER)
            {
                //if player has orb, place orb
                Game.SetOrbLocation(checkLocation);
                hasOrb = true;
            }

            UpdateOrb();

            //update orb locations in other places (player and inventory)
            Game.UpdateOrbLocation();
        }

        public void UpdateOrb()
        {
            //check if orb is on this pedestal
            hasOrb = Game.GetOrbLocation() == checkLocation;

            //show orb if on pedestal
            orbObject.SetActive(hasOrb);
        }
    }
}