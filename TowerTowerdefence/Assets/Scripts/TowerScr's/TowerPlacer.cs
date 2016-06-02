using UnityEngine;
using System.Collections;

public class TowerPlacer : MonoBehaviour {

    private GameObject heldObj;
    private int heldObjPrice;

    private Transform checkObj;
    private Transform[] checkPoints = new Transform[4];

    public Transform areaIndicator;

    private ResourceManager Rmaneger;

    private bool placebleRemember = true;

    public Material unplacebleMat;
    public Material placebleMat;

    private Material originalMat;

    // Use this for initialization
    void Start () {
        Rmaneger = gameObject.GetComponent<ResourceManager>();

        checkObj = (Instantiate(Resources.Load("PlacerObj")) as GameObject).transform;
        checkPoints[0] = checkObj.GetChild(0);
        checkPoints[1] = checkObj.GetChild(1);
        checkPoints[2] = checkObj.GetChild(2);
        checkPoints[3] = checkObj.GetChild(3);
    }
    
    public void holdNewObj(GameObject obj, int price)
    {
        heldObjPrice = price;
        heldObj = obj;
        gameObject.GetComponent<TowerUpgrader>().shutDown();
        areaIndicator.gameObject.SetActive(true);
        float tempInt = obj.GetComponent<TowerBase>().range * 2;
        areaIndicator.localScale = new Vector3(tempInt, tempInt, tempInt);

        originalMat = obj.GetComponentInChildren<MeshRenderer>().material;
        foreach (MeshRenderer mes in obj.GetComponentsInChildren<MeshRenderer>())
        {
            mes.material = placebleMat;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (heldObj != null)
        {
            RaycastHit hit;
            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit,1000, 1 << 8))
            {
                heldObj.transform.position = hit.point;
                heldObj.transform.rotation = Quaternion.LookRotation(hit.normal);
                heldObj.transform.eulerAngles += new Vector3(90,0,0);
                
                areaIndicator.position = heldObj.transform.position;

                checkObj.position = heldObj.transform.position;
                checkObj.rotation = heldObj.transform.rotation;

                bool placeble = true;

                for (int i =0;i<4;i++)
                {
                    RaycastHit hit2;
                    if (!Physics.Raycast(checkPoints[i].position,-checkPoints[i].up, out hit2, 1.5f, 1 << 8))
                    {
                        i = 4;
                        placeble = false;
                    }
                }
                if (Physics.OverlapSphere(heldObj.transform.position, 0.8f, 1 << 9).Length > 0)
                {
                    placeble = false;
                }

                if (placeble)
                {
                    //if tower is in a placeble position
                    if (Input.GetMouseButtonDown(0))
                    {
                        //change material back to original
                        foreach (MeshRenderer mes in heldObj.GetComponentsInChildren<MeshRenderer>())
                        {
                            mes.material = originalMat;
                        }

                        //deduct gold
                        Rmaneger.BuildPayment(heldObjPrice);

                        heldObj.GetComponent<TowerBase>().turnTowerOn(); // activate tower
                        heldObj = null;
                        gameObject.GetComponent<TowerUpgrader>().enabled = true;
                        areaIndicator.gameObject.SetActive(false);


                    }
                    else if(!placebleRemember)
                    {
                        areaIndicator.gameObject.SetActive(true);
                        foreach (MeshRenderer mes in heldObj.GetComponentsInChildren<MeshRenderer>())
                        {
                            mes.material = placebleMat;
                        }
                    }
                }
                else if(placebleRemember)
                {
                    //set to implaceble material
                    foreach (MeshRenderer mes in heldObj.GetComponentsInChildren<MeshRenderer>())
                    {
                        mes.material = unplacebleMat;
                    }

                    areaIndicator.gameObject.SetActive(false);
                }
                placebleRemember = placeble;

                if (Input.GetMouseButtonDown(1))
                {
                    Destroy(heldObj.gameObject);
                    areaIndicator.gameObject.SetActive(false);
                }
            }
        }
	}
}
