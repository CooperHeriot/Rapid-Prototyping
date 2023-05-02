using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getPlayerName : MonoBehaviour
{
    public string userName;
    // Start is called before the first frame update
    void Start()
    {
        //userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

        userName = System.Environment.UserName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
