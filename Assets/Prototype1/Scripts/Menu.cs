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
        //restarter = SceneManager.GetActiveScene().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadTheScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneToLoad);
        
    }

    public void Resstart()
    {
        Time.timeScale = 1;
        //SceneManager.LoadScene(restarter);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Quitt()
    {
        Application.Quit();
    }

    public void TitleScreen()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Title");
        
    }
}
