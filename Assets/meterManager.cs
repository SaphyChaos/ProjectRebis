using PixelCrushers.DialogueSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meterManager : MonoBehaviour
{
    public GameObject staticResources; //grabbing the static resources gameobject
    public GameObject uiUpdater; //grabbing the uiUpdater gameobject
    public GameObject meterA;
    public GameObject meterB;
    public GameObject meterC;
    public GameObject meterD;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AdjustA(int val)
    {
        staticResources.GetComponent<staticResources>().a += val;
        uiUpdater.GetComponent<UIUpdater>().changeSize(meterA, staticResources.GetComponent<staticResources>().a);
        DialogueLua.SetVariable("A", staticResources.GetComponent<staticResources>().a);
    }
    public void AdjustB(int val)
    {
        staticResources.GetComponent<staticResources>().b += val;
        uiUpdater.GetComponent<UIUpdater>().changeSize(meterB, staticResources.GetComponent<staticResources>().b);
        DialogueLua.SetVariable("B", staticResources.GetComponent<staticResources>().b);
    }
    public void AdjustC(int val)
    {
        staticResources.GetComponent<staticResources>().c += val;
        uiUpdater.GetComponent<UIUpdater>().changeSize(meterC, staticResources.GetComponent<staticResources>().c);
        DialogueLua.SetVariable("C", staticResources.GetComponent<staticResources>().c);
    }

    public void AdjustD(int val)
    {
        staticResources.GetComponent<staticResources>().d += val;
        uiUpdater.GetComponent<UIUpdater>().changeSize(meterD, staticResources.GetComponent<staticResources>().d);
        DialogueLua.SetVariable("D", staticResources.GetComponent<staticResources>().d);
    }

}
