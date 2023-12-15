using PixelCrushers.DialogueSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DropTarget : MonoBehaviour, IDropHandler//drop target handles all the values for ingrediants. Think of droptarget as a feature of Potion. It's literally what reads the ingrediants and contributes to potion values accordingly.
{
    public string DroppedItem = "empty";
    public GameObject UIManager;
    public GameObject Potion;
    public GameObject Slot1;
    public GameObject Slot2;
    public GameObject Slot3;
    public bool Slot1Filled;
    public bool Slot2Filled;
    public bool Slot3Filled;
    //public GameObject DialogueOption1;
    //public GameObject DialogueOption2;
    //public GameObject DialogueOption3;
    //public GameObject DialogueOption4;
    public void PotionReset()
    {
        Slot1Filled = false;
        Slot2Filled = false;
        Slot3Filled = false;
        Slot1 = null;
        Slot2 = null;
        Slot3 = null;
    }
    private void SlotFiller(string objectName)
    {
        var myObject = GameObject.Find(objectName);//naming shit properly is important!
        if(myObject == null)
        {
            Debug.Log("that object couldn't be found even though you just dropped it??");
            return;
        }
        if (Slot1Filled)
        {
            if (Slot2Filled)
            {
                Slot3Filled = true;
                Slot3.GetComponent<Image>().sprite = myObject.GetComponent<Image>().sprite;
                return;
            }
            Slot2Filled = true;
            Slot2.GetComponent<Image>().sprite = myObject.GetComponent<Image>().sprite;
        }
        else
        {
            Slot1Filled = true;
            Slot1.GetComponent<Image>().sprite = myObject.GetComponent<Image>().sprite;
        }
    }
    public void OnDrop(PointerEventData eventData)
    {
        if (Slot3Filled)
        {
            return;
        }
        GameObject dropped = eventData.pointerDrag;
        DraggableItem draggableItem = dropped.GetComponent<DraggableItem>();
        DroppedItem = draggableItem.name;

        //Debug.Log("oh!"+draggableItem.name);
        //UIManager.GetComponent<UIUpdater>().moveIngredientsOut();
        SlotFiller(DroppedItem);
        if (DroppedItem == "Dick")
        {
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
