using UnityEngine;
using System.Collections;

public class TowerPlacer : MonoBehaviour {
    //Currently held obj
    private GameObject heldObj;
    //Cost to place heldObj
    private int heldObjPrice;
    //In scene obj to be moved with heldobj(is used to check for worldedges)
    private Transform checkObj;
    //the 4 points in checkObj from which cast will be done to check for world edges
    private Transform[] checkPoints = new Transform[4];
    //Sphere to show range of selected tower
    public Transform areaIndicator;

    private ResourceManager Rmaneger;
    //bool to save if the heldObj was placeble last frame
    private bool placebleRemember = true;
    //materials to apply to heldObj when its placeble/unplaceble
    public Material unplacebleMat;
    public Material placebleMat;
    //var to save original material of heldObj
    private Material originalMat;

    // Use this for initialization
    void Start () {
        // save resourcemaneger for later use
        Rmaneger = gameObject.GetComponent<ResourceManager>();
        //Instanciate and set checkObj and all its checkPoints
        checkObj = (Instantiate(Resources.Load("PlacerObj")) as GameObject).transform;
        checkPoints[0] = checkObj.GetChild(0);
        checkPoints[1] = checkObj.GetChild(1);
        checkPoints[2] = checkObj.GetChild(2);
        checkPoints[3] = checkObj.GetChild(3);
    }
    /// <summary>
    /// Give new tower to place, also set price of given tower
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="price"></param>
    public void holdNewObj(GameObject obj, int price)
    {
        //set tower and price
        heldObjPrice = price;
        heldObj = obj;
        //turn off upgrade system while placing a tower
        gameObject.GetComponent<TowerUpgrader>().shutDown();
        //turn on areaIndicator while placing
        areaIndicator.gameObject.SetActive(true);
        //Scale areaIndicator with the range of given tower
        float tempInt = obj.GetComponent<TowerBase>().range * 2;
        areaIndicator.localScale = new Vector3(tempInt, tempInt, tempInt);
        //save towers original material
        originalMat = obj.GetComponentInChildren<MeshRenderer>().material;
        //apply placebleMat to all meshes of given tower
        foreach (MeshRenderer mes in obj.GetComponentsInChildren<MeshRenderer>())
        {
            mes.material = placebleMat;
        }
    }
	
	// Update is called once per frame
	void Update () {
        //if an object is currently being held
        if (heldObj != null)
        {
            //check if mouse is over a placeble surface
            RaycastHit hit;
            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit,1000, 1 << 8))
            {
                //move heldObj to mouseposition
                heldObj.transform.position = hit.point;
                //alighn heldObj with the surface its being held over
                heldObj.transform.rotation = Quaternion.LookRotation(hit.normal);
                heldObj.transform.eulerAngles += new Vector3(90,0,0);
                //move areaIndicator with heldObj
                areaIndicator.position = heldObj.transform.position;
                //move/rotate checkObj with heldObj
                checkObj.position = heldObj.transform.position;
                checkObj.rotation = heldObj.transform.rotation;
                //bool to save wether or not heldObj is placeble
                bool placeble = true;
                //cast rays from all checkPoints to check if heldObj of fully on a surface, and not hanging off a ledge
                //make unplaceble if not
                for (int i =0;i<4;i++)
                {
                    RaycastHit hit2;
                    if (!Physics.Raycast(checkPoints[i].position,-checkPoints[i].up, out hit2, 1.5f, 1 << 8))
                    {
                        i = 4;
                        placeble = false;
                    }
                }
                //check if there are any other towers to close to heldObj
                //make unplaceble if not
                if (placeble && Physics.OverlapSphere(heldObj.transform.position, 0.8f, 1 << 9).Length > 0)
                {
                    placeble = false;
                }
                //if tower is in a placeble position
                if (placeble)
                {
                    //when player attempts to place tower
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
                        //turn upgradeSystem back on
                        gameObject.GetComponent<TowerUpgrader>().enabled = true;

                        areaIndicator.gameObject.SetActive(false);


                    }
                    //if heldObj was not placeble last frame
                    else if (!placebleRemember)
                    {
                        //turn areaIndicator back on
                        areaIndicator.gameObject.SetActive(true);
                        //set tower material to placebleMat
                        foreach (MeshRenderer mes in heldObj.GetComponentsInChildren<MeshRenderer>())
                        {
                            mes.material = placebleMat;
                        }
                    }
                }
                //if heldObj was placeble last frame
                else if (placebleRemember)
                {
                    //turn areaIndicator off
                    areaIndicator.gameObject.SetActive(false);
                    //set to implaceble material
                    foreach (MeshRenderer mes in heldObj.GetComponentsInChildren<MeshRenderer>())
                    {
                        mes.material = unplacebleMat;
                    }
                }
                //set if tower was placeble for next frame
                placebleRemember = placeble;

                //if player right clicks, cancel towerplacing
                if (Input.GetMouseButtonDown(1))
                {
                    Destroy(heldObj.gameObject);
                    areaIndicator.gameObject.SetActive(false);
                }
            }
        }
	}
}
