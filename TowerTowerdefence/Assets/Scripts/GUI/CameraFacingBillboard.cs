using UnityEngine;
using System.Collections;

public class CameraFacingBillboard : MonoBehaviour {

    public Camera mainCam;

    // Use this for initialization
    void Start()
    {
        //Getting the main camera
        mainCam = Camera.main;
    }
    
    // Update is called once per frame
    void Update ()
    {
        //Make UI object face the camera at all times
        transform.LookAt(transform.position + mainCam.transform.rotation * Vector3.forward, mainCam.transform.rotation * Vector3.up);
    }
}
