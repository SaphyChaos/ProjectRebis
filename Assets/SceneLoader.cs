using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using PixelCrushers.DialogueSystem;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadEnterTextWorld()
    {
        //PixelCrushers.SceneTransitionManager.EnterScene("enterTextWorld");
        SceneManager.LoadScene("enterTextWorld");
    }
    public void LoadSampleScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
