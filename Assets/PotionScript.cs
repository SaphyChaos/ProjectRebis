using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionScript : MonoBehaviour
{
    public int TreatsAssholeChappedVal;
    public int TreatsColdVal;
    public int TreatsItchyVal;
    public int TreatsDepressedVal;
    public GameObject Patient;//for this to work with any patient at runtime, we first need to find the patient in the scene
    // Start is called before the first frame update
    private void Start()
    {
        LoadPotion();
    }
    public void GivePotion()
    {
        Patient.GetComponent<PatientScript>().AssholeChappedVal -= TreatsAssholeChappedVal;
        Patient.GetComponent<PatientScript>().ColdVal -= TreatsColdVal;
        Patient.GetComponent<PatientScript>().ItchyVal -= TreatsItchyVal;
        Patient.GetComponent<PatientScript>().DepressedVal -= TreatsDepressedVal;
        ResetPotion();
    }
    public void ResetPotion()
    {
        TreatsAssholeChappedVal = 0;
        TreatsColdVal = 0;
        TreatsItchyVal = 0;
        TreatsDepressedVal = 0;
    }
    public void SavePotion()
    {
        ES3.Save("TreatsAssholeChappedVal", TreatsAssholeChappedVal);
        ES3.Save("TreatsColdVal", TreatsColdVal);
        ES3.Save("TreatsItchyVal", TreatsItchyVal);
        ES3.Save("TreatsDepressedVal", TreatsDepressedVal);
    }
    public void LoadPotion()
    {
        TreatsAssholeChappedVal = ES3.Load<int>("TreatsAssholeChappedVal", 0);
        TreatsColdVal = ES3.Load<int>("TreatsColdVal", 0);
        TreatsItchyVal = ES3.Load<int>("TreatsItchyVal", 0);
        TreatsDepressedVal = ES3.Load<int>("TreatsDepressedVal", 0);
    }
}
