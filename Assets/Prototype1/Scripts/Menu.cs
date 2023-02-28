using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string SceneToLoad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadTheScene()
    {
        SceneManager.LoadScene(SceneToLoad);
    }

    public void Quitt()
    {
        Application.Quit();
    }
}
