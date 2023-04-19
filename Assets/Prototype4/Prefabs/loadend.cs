using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadend : MonoBehaviour
{
    public bool Load;
    public string scenee = "Prototype4Win";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Load == true)
        {
            SceneManager.LoadScene(scenee);
        }
    }
}
