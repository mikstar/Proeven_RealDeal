using UnityEngine;
using System.Collections;

public class CamControll : MonoBehaviour {

    private bool inputHeld;
    private Transform camTrans;
    private Vector2 easePoint = Vector2.zero;
    public float testYmove;

	// Use this for initialization
	void Start () {
        camTrans = Camera.main.transform;
	}
	
	// Update is called once per frame
	void Update() {
        if (Input.GetMouseButtonDown(1))
        {
            inputHeld = true;
            easePoint = Input.mousePosition;
        }

        if (inputHeld)
        {
            if (Input.GetMouseButtonUp(1))
            {
                inputHeld = false;
                easePoint = (Vector2)Input.mousePosition - easePoint;
            }
            else
            {
                Vector2 newPoint = Vector2.Lerp(easePoint, Input.mousePosition, 0.1f);

                camTrans.RotateAround(new Vector3(0, camTrans.position.y, 0), Vector3.up, (newPoint.x - easePoint.x) * 0.3f);

                Vector3 tempPos = camTrans.localPosition + new Vector3(0, (newPoint.y - easePoint.y) * -0.05f, 0);
                tempPos.y = Mathf.Clamp(tempPos.y, 0, 30);
                camTrans.localPosition = tempPos;

                easePoint = newPoint;
            }

        }
        else
        {

            camTrans.RotateAround(new Vector3(0, camTrans.position.y, 0), Vector3.up, (easePoint.x*0.1f) * 0.3f);

            Vector3 tempPos = camTrans.localPosition + new Vector3(0, (easePoint.y*0.1f) * -0.05f, 0);
            tempPos.y = Mathf.Clamp(tempPos.y, 0, 30);
            camTrans.localPosition = tempPos;

            easePoint = easePoint * 0.95f;
        }

    }
}
