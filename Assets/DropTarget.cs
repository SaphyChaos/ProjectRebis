using PixelCrushers.DialogueSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropTarget : MonoBehaviour, IDropHandler
{
    public string DroppedItem = "empty";
    public GameObject UIManager;
    public GameObject DialogueOption1;
    public GameObject DialogueOption2;
    public GameObject DialogueOption3;
    public GameObject DialogueOption4;
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        DraggableItem draggableItem = dropped.GetComponent<DraggableItem>();
        DroppedItem = draggableItem.name;
        Debug.Log("oh!"+draggableItem.name);
        //UIManager.GetComponent<UIUpdater>().moveIngredientsOut();
        if (DroppedItem == "Dick")
        {
            DialogueOption1.gameObject.GetComponent<DialogueSystemTrigger>().OnUse();
        }
        else if (DroppedItem == "Piss")
        {
            DialogueOption2.gameObject.GetComponent<DialogueSystemTrigger>().OnUse();
        }
        else if (DroppedItem == "Snail")
        {
            DialogueOption3.gameObject.GetComponent<DialogueSystemTrigger>().OnUse();
        }
        else if(DroppedItem == "Pussy")
        {    
            DialogueOption4.gameObject.GetComponent<DialogueSystemTrigger>().OnUse();
        }
    }
}
