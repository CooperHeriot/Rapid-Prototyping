using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class getPlayerName : MonoBehaviour
{
    public string userName;

    public TextMeshPro text;
    // Start is called before the first frame update
    void Start()
    {
        //userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

        userName = System.Environment.UserName;

        text.text = ("Go on " + userName + ", I believe in you");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
