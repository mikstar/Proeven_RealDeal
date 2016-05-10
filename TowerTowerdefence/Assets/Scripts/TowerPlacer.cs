using UnityEngine;
using System.Collections;

public class TowerPlacer : MonoBehaviour {

    private GameObject heldObj;

	// Use this for initialization
	void Start () {
	    
	}
    
    public void holdNewObj(GameObject obj)
    {
        heldObj = obj;
    }
	
	// Update is called once per frame
	void Update () {
        if (heldObj != null)
        {
            RaycastHit hit;
            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit,1000, 1 << 8))
            {
                heldObj.transform.position = hit.point;
                heldObj.transform.rotation = Quaternion.FromToRotation(heldObj.transform.up, hit.normal) * heldObj.transform.rotation;

                if (Input.GetMouseButtonDown(0))
                {
                    heldObj.GetComponent<TowerBase>().turnTowerOn();
                    heldObj = null;
                }
            }
        }
	}
}
