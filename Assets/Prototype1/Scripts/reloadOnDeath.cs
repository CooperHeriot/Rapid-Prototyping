using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reloadOnDeath : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -10)
        {
            //Scene skene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
