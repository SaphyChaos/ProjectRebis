using PixelCrushers.DialogueSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropTarget : MonoBehaviour, IDropHandler//drop target handles all the values for ingrediants. Think of droptarget as a feature of Potion. It's literally what reads the ingrediants and contributes to potion values accordingly.
{
    public string DroppedItem = "empty";
    public GameObject UIManager;
    public GameObject Potion;
    //public GameObject DialogueOption1;
    //public GameObject DialogueOption2;
    //public GameObject DialogueOption3;
    //public GameObject DialogueOption4;
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        DraggableItem draggableItem = dropped.GetComponent<DraggableItem>();
        DroppedItem = draggableItem.name;
        //Debug.Log("oh!"+draggableItem.name);
        //UIManager.GetComponent<UIUpdater>().moveIngredientsOut();
        if (DroppedItem == "Dick")
        {
            print("oh dick");
            Potion.GetComponent<PotionScript>().TreatsDepressedVal += 25;
            Potion.GetComponent<PotionScript>().TreatsAssholeChappedVal -= 50;
        }
        else if (DroppedItem == "Piss")
        {
            Potion.GetComponent<PotionScript>().TreatsColdVal += 20;
            Potion.GetComponent<PotionScript>().TreatsAssholeChappedVal += 10;
        }
        else if (DroppedItem == "Snail")
        {
            Potion.GetComponent<PotionScript>().TreatsColdVal -= 10;
            Potion.GetComponent<PotionScript>().TreatsAssholeChappedVal += 50;
            Potion.GetComponent<PotionScript>().TreatsItchyVal += 25;
        }
        else if(DroppedItem == "Pussy")
        {
            Potion.GetComponent<PotionScript>().TreatsColdVal += 50;
            Potion.GetComponent<PotionScript>().TreatsDepressedVal += 50;
        }
    }
}
