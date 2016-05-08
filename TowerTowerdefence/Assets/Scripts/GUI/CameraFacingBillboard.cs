using UnityEngine;
using System.Collections;

public class CameraFacingBillboard : MonoBehaviour {

    public Camera mainCam;

    void Update () {
        transform.LookAt(transform.position + mainCam.transform.rotation * Vector3.forward, mainCam.transform.rotation * Vector3.up);
    }
}
