using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InventoryDemo
{
    public interface IRoom
    {
        //can be added to other room controllers
        void RefreshRoom();
    }
}