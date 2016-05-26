using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TowerUpgrader : MonoBehaviour {

    private TowerBase selectedTower;
    public Image UpgradeMenu;

    public Text nameTxt;
    public Text lvlTxt;
    public GameObject buildParticle;

    public Transform areaIndicator;
    private ResourceManager Rman;

    // Use this for initialization
    void Start () {
        Rman = gameObject.GetComponent<ResourceManager>();

    }

    public void shutDown()
    {
        UpgradeMenu.gameObject.SetActive(false);
        selectedTower = null;
        this.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(selectedTower == null)
        {
            RaycastHit hit;
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 1000, 1<<9 | 1<<8) && hit.transform.tag == "Tower")
                {
                    ActivateMenu(hit.transform.parent.GetComponent<TowerBase>());
                }
            }
        }
        else
        {
            UpgradeMenu.rectTransform.position = Camera.main.WorldToScreenPoint(selectedTower.transform.position) + new Vector3(140, 0, 0);

            RaycastHit hit;
            if (Input.GetMouseButtonDown(0) && EventSystem.current.currentSelectedGameObject == null)
            {
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 1000, 1 << 9 | 1 << 8) && hit.transform.tag == "Tower")
                {
                    ActivateMenu(hit.transform.parent.GetComponent<TowerBase>());
                }
                else
                {
                    UpgradeMenu.gameObject.SetActive(false);
                    areaIndicator.gameObject.SetActive(false);
                }
            }

            //Debug.Log(EventSystem.current.currentSelectedGameObject.name);
        }
    }

    void ActivateMenu(TowerBase newtower)
    {
        selectedTower = newtower;
        UpgradeMenu.gameObject.SetActive(true);
        UpgradeMenu.rectTransform.position = Camera.main.WorldToScreenPoint(selectedTower.transform.position) + new Vector3(140, 0, 0);

        nameTxt.text = selectedTower.towerType;
        lvlTxt.text = selectedTower.towerLvl + "";

        areaIndicator.position = newtower.transform.position;

        float tempInt = newtower.range * 2;
        areaIndicator.localScale = new Vector3(tempInt, tempInt, tempInt);
        areaIndicator.gameObject.SetActive(true);
    }

    public void upgradeTower()
    {
        if(selectedTower.upgradeCost > 0)
        {
            if (PlayerDB.Instance.gold >= selectedTower.upgradeCost)
            {
                Rman.BuildPayment(selectedTower.upgradeCost);

                TowerBase temptower = Instantiate(Resources.Load("Towers/" + selectedTower.towerType + "_lv" + (selectedTower.towerLvl + 1)) as GameObject).GetComponent<TowerBase>();
                Debug.Log("Towers/" + selectedTower.towerType + "_lv" + (selectedTower.towerLvl + 1));
                //TowerBase temptower = Instantiate(Resources.Load("Towers/Basic_lv2") as GameObject).GetComponent<TowerBase>();
                temptower.transform.position = selectedTower.transform.position;
                temptower.transform.rotation = selectedTower.transform.rotation;
                Destroy(selectedTower.gameObject);
                temptower.turnTowerOn();
                ActivateMenu(temptower);
                GameObject partemp = Instantiate(buildParticle) as GameObject;
                partemp.transform.position = selectedTower.transform.position;
                partemp.transform.LookAt(selectedTower.transform.position + selectedTower.transform.up);
            }

            
        }
    }
    public void sellTower()
    {
        UpgradeMenu.gameObject.SetActive(false);
        Destroy(selectedTower.gameObject);

        areaIndicator.gameObject.SetActive(false);
    }
}
