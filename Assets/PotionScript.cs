using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionScript : MonoBehaviour
{
    public int TreatsAssholeChappedVal;
    public int TreatsColdVal;
    public int TreatsItchyVal;
    public int TreatsDepressedVal;
    public GameObject Patient;
    // Start is called before the first frame update
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
}
