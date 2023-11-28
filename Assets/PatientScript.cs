using PixelCrushers.DialogueSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientScript : MonoBehaviour
{
    public int AssholeChappedVal;
    public int ColdVal;
    public int ItchyVal;
    public int DepressedVal;
    //important!! only one Patient at a time!
    public void Update()//once again I do not trust the start function to work properly so we're just updating the dialogue values constantly
    {
        DialogueLua.SetVariable("AssholeChapped", AssholeChappedVal);
        DialogueLua.SetVariable("Cold", ColdVal);
        DialogueLua.SetVariable("Itchy", ItchyVal);
        DialogueLua.SetVariable("Depressed", DepressedVal);
    }
}
