using UnityEngine;
using System.Collections;

public class CamControll : MonoBehaviour {

    private bool inputHeld;
    private Transform camTrans;

    //(when mouse down)virtual screenPoint that dragged around my mousemovement, the camera's rotation will follow this points movement
    //(when mouse up)degrading velocity of the camera rotation/movement
    private Vector2 easePoint = Vector2.zero;

	// Use this for initialization
	void Start () {
        //save camera transform for use in the update
        camTrans = Camera.main.transform;
	}
	
	// Update is called once per frame
	void Update() {
        //wait for mouseinput to begin moving the easePoint
        if (Input.GetMouseButtonDown(1))
        {
            inputHeld = true;
            easePoint = Input.mousePosition;
        }

        if (inputHeld)
        {
            //wait for mouse to be released to stop moving the easePoint
            if (Input.GetMouseButtonUp(1))
            {
                inputHeld = false;
                //set easepoint so its the velicity at wich easepoint was being dragged
                easePoint = (Vector2)Input.mousePosition - easePoint;
            }
            else
            {
                //newpoint is the position that easePoint will be dragged to this frame
                Vector2 newPoint = Vector2.Lerp(easePoint, Input.mousePosition, 0.1f);
                //rotate the camera around the world center, ammount turned is how far easePoint is being dragged in the x direction
                camTrans.RotateAround(new Vector3(0, camTrans.position.y, 0), Vector3.up, (newPoint.x - easePoint.x) * 0.3f);
                //move y position of camera, ammount moved is how far easePoint is being dragged in the y direction
                Vector3 tempPos = camTrans.localPosition + new Vector3(0, (newPoint.y - easePoint.y) * -0.05f, 0);
                //ensure camera doesnt go past level bounds
                tempPos.y = Mathf.Clamp(tempPos.y, 0, 30);

                camTrans.localPosition = tempPos;
                easePoint = newPoint;
            }

        }
        else
        {
            //rotate the camera around the world center, ammount turned is easePoint.x
            camTrans.RotateAround(new Vector3(0, camTrans.position.y, 0), Vector3.up, (easePoint.x*0.1f) * 0.3f);
            //move y position of camera, ammount turned is easePoint.y
            Vector3 tempPos = camTrans.localPosition + new Vector3(0, (easePoint.y*0.1f) * -0.05f, 0);
            //ensure camera doesnt go past level bounds
            tempPos.y = Mathf.Clamp(tempPos.y, 0, 30);

            camTrans.localPosition = tempPos;

            //degrade easepoint
            easePoint = easePoint * 0.95f;
        }

    }
}
