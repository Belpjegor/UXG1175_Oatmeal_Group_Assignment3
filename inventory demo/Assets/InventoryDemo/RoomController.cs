using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InventoryDemo
{
    public class RoomController : MonoBehaviour, IRoom
    {
        public string roomName;
        public List<PedestalController> pedestalList = new List<PedestalController>();

        // Start is called before the first frame update
        void Start()
        {
            //set room controller when object started
            Game.SetCurrentRoom(this);

            RefreshRoom();
        }

        public void RefreshRoom()
        {
            //update orb display on all pedestals
            foreach (PedestalController pedestal in pedestalList)
            {
                pedestal.UpdateOrb();
            }
        }
    }
}