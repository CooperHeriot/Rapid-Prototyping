using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBehav : MonoBehaviour
{
    public GameObject camObj;
    public GameObject camAnch;

    public GameObject UpDownLooker;

    public float Sensitivity;

    public GameObject Target;

    public GameObject Player;
    private ChameleonMove PC;

    private float CamDist;
    // Start is called before the first frame update
    void Start()
    {
        CamDist = Vector3.Distance(UpDownLooker.transform.position, camAnch.transform.position);
        PC = Player.GetComponent<ChameleonMove>();
        PC.turnSens = Sensitivity;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0 , Input.GetAxis("Mouse X") * Sensitivity * Time.deltaTime, 0);

        UpDownLooker.transform.Rotate(Input.GetAxis("Mouse Y") * Sensitivity * -1 * Time.deltaTime, 0, 0);

        //Camera clamping
        
        float cameraXRot = UpDownLooker.transform.localEulerAngles.x;
        if (cameraXRot > 180)
        {
            cameraXRot -= 360;
        }
        cameraXRot = Mathf.Clamp(cameraXRot, -85, 85);
        UpDownLooker.transform.localRotation = Quaternion.Euler(cameraXRot, 0, 0);

        //dont clip through colliders
        RaycastHit hit;
        if (Physics.Raycast(UpDownLooker.transform.position, UpDownLooker.transform.forward * -1, out hit, CamDist))
        {
            camObj.transform.position = new Vector3(hit.point.x, hit.point.y + 0.9f, hit.point.z);
        } else
        {
            camObj.transform.position = camAnch.transform.position;
        }


        
    }

    public void ChangeSens(float NewSens)
    {
        Sensitivity = NewSens;
        PC.turnSens = Sensitivity;
    }
}
