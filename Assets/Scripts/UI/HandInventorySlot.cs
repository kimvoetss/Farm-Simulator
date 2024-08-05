using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HandInventorySlot : InventorySlots
{
    public override void OnPointerClick(PointerEventData eventData)
    {
        //Move item from hand to inventory
        InventoryManager.Instance.HandToInventory(inventoryType);
    }
}