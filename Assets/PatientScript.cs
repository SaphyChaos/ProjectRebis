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
    private void Start()
    {
        LoadPatient();
    }
    public void Update()//once again I do not trust the start function to work properly so we're just updating the dialogue values constantly
    {
        DialogueLua.SetVariable("AssholeChapped", AssholeChappedVal);
        DialogueLua.SetVariable("Cold", ColdVal);
        DialogueLua.SetVariable("Itchy", ItchyVal);
        DialogueLua.SetVariable("Depressed", DepressedVal);
    }
    public void SavePatient()//if only it were so easy...
    {
        ES3.Save("AssholeChappedVal", AssholeChappedVal);
        ES3.Save("ColdVal", ColdVal);
        ES3.Save("ItchyVal", ItchyVal);
        ES3.Save("DepressedVal", DepressedVal);
    }
    public void LoadPatient()
    {
        AssholeChappedVal = ES3.Load<int>("AssholeChappedVal", 0);
        ColdVal = ES3.Load<int>("ColdVal", 0);
        ItchyVal = ES3.Load<int>("ItchyVal", 0);
        DepressedVal = ES3.Load<int>("DepressedVal", 0);
    }
}
