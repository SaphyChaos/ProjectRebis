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
        DialogueLua.SetVariable("A", DialogueLua.GetVariable("A").asInt + val);
        uiUpdater.GetComponent<UIUpdater>().changeSize(meterA, DialogueLua.GetVariable("A").asInt);
    }
    public void AdjustB(int val)
    {
        DialogueLua.SetVariable("B", DialogueLua.GetVariable("B").asInt + val);
        uiUpdater.GetComponent<UIUpdater>().changeSize(meterB, DialogueLua.GetVariable("B").asInt);
    }
    public void AdjustC(int val)
    {
        DialogueLua.SetVariable("C", DialogueLua.GetVariable("C").asInt + val);
        uiUpdater.GetComponent<UIUpdater>().changeSize(meterB, DialogueLua.GetVariable("C").asInt);
    }

    public void AdjustD(int val)
    {
        DialogueLua.SetVariable("D", DialogueLua.GetVariable("D").asInt + val);
        uiUpdater.GetComponent<UIUpdater>().changeSize(meterB, DialogueLua.GetVariable("D").asInt);
    }

}
