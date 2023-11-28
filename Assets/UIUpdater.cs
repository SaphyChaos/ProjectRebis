using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIUpdater : MonoBehaviour
{
    public GameObject meterManager;
    public GameObject ingredientBar;
    public GameObject dragOffPoint;
    public Vector3 ingredientBarPreviousPos;
    // Start is called before the first frame update
    void Start()
    {
        ingredientBarPreviousPos = new Vector3(ingredientBar.transform.position.x, ingredientBar.transform.position.y, ingredientBar.transform.position.z);
        //moveIngredientsOut();
    }
    
    // Update is called once per frame
    void Update()
    {
        //this shit is dumb, but we need the ui to update when reloading the game, since save and reload only applies to dialogue things
        //also, this should only be called once when the game is loaded, but I don't know how to do that. void Awake() doesn't work since
        //it wakes up before the scene finishes loading, therefor it uses values from before the game was loaded. Shit sucks honestly.
        meterManager.GetComponent<meterManager>().AdjustA(0);
        meterManager.GetComponent<meterManager>().AdjustB(0);
        meterManager.GetComponent<meterManager>().AdjustC(0);
        meterManager.GetComponent<meterManager>().AdjustD(0);
}
    public void changeSize(GameObject myObject, float myValue)
    {
        //print(myValue / 100);
        myObject.GetComponent<Slider>().value = myValue/100;
    }
    /*
    public void moveIngredientsOut()
    {
        ingredientBar.transform.position = new Vector3(dragOffPoint.transform.position.x, dragOffPoint.transform.position.y, dragOffPoint.transform.position.z);
    }
    public void moveIngredientsIn()
    {
        ingredientBar.transform.position = new Vector3(ingredientBarPreviousPos.x, ingredientBarPreviousPos.y, ingredientBarPreviousPos.z);
    }
    */
}
