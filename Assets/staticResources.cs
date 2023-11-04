using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staticResources : MonoBehaviour
{
    public int a;
    public int b;
    public int c;
    public int d;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject); //this makes the gameobject attached to this script stick around after
        //a = 100;
        //b = 100;
        //c = 100;
        //d = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
