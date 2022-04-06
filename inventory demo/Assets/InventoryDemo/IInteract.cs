using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InventoryDemo
{
    public interface IInteract
    {
        //can be added to other interactable object controllers
        void Interact();
    }
}