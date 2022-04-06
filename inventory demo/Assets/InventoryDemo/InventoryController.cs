using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace InventoryDemo
{
    public class InventoryController : MonoBehaviour
    {
        public Image orbImage;

        // Start is called before the first frame update
        void Start()
        {
            //set inventory controller when object started
            Game.SetInventory(this);

            RefreshInventory();
        }

        public void RefreshInventory()
        {
            //show orb if in inventory
            orbImage.gameObject.SetActive(Game.GetOrbLocation() == OrbLocation.PLAYER);
        }
    }
}