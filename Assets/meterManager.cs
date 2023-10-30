using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meterManager : MonoBehaviour
{
    public GameObject staticResources;
    public GameObject uiUpdater;
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
    public void AdjustA(int a)
    {
        staticResources.GetComponent<staticResources>().a += a;
        print(staticResources.GetComponent<staticResources>().a);
        uiUpdater.GetComponent<UIUpdater>().changeSize(meterA, staticResources.GetComponent<staticResources>().a);
    }
    public void AdjustB(int a)
    {
        staticResources.GetComponent<staticResources>().b += a;
        uiUpdater.GetComponent<UIUpdater>().changeSize(meterB, a);
    }
    public void AdjustC(int a)
    {
        staticResources.GetComponent<staticResources>().c += a;
        uiUpdater.GetComponent<UIUpdater>().changeSize(meterC, a);
    }
    public void AdjustD(int a)
    {
        staticResources.GetComponent<staticResources>().d += a;
        uiUpdater.GetComponent<UIUpdater>().changeSize(meterD, a);
    }
}
