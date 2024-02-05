using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI_CraftSlot : UI_ItemSlot
{
    private void OnEnable()
    {
        UpdataSlot(item);  
    }
    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        ItemData_Equipment craftData = item.data as ItemData_Equipment;
        Inventory.instance.CanCraft(craftData ,craftData.craftingMaterials);
    }

}
