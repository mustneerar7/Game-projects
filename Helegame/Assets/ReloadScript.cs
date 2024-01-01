using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void reloadScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void reloadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
