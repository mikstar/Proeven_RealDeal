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
    //tooltip scripts on menubuttons
    public TooltipAssighn Upgradetrigger;
    public TooltipAssighn selltrigger;

    // Use this for initialization
    void Start () {
        //save resourceManeger to use when a tower is upgraded
        Rman = gameObject.GetComponent<ResourceManager>();

    }

    /// <summary>
    /// Fully disable this menu, so it cant be activated either
    /// (to be uses when other functionality is turned on that could cause the player to click on towers)
    /// </summary>
    public void shutDown()
    {
        UpgradeMenu.gameObject.SetActive(false);
        selectedTower = null;
        this.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if no tower is selected
        if(selectedTower == null)
        {

            RaycastHit hit;
            if (Input.GetMouseButtonDown(0))
            {
                //when clicked, check if a tower is selected
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 1000, 1<<9 | 1<<8) && hit.transform.tag == "Tower")
                {
                    //activate upgrade menu for selected tower
                    ActivateMenu(hit.transform.parent.GetComponent<TowerBase>());
                }
            }
        }
        //if a tower is selected
        else
        {
            //make upgrademenu follow selected tower
            UpgradeMenu.rectTransform.position = Camera.main.WorldToScreenPoint(selectedTower.transform.position) + new Vector3(140, 0, 0);

            //when clicked ensure that the player is not clicking a ui button
            RaycastHit hit;
            if (Input.GetMouseButtonDown(0) && EventSystem.current.currentSelectedGameObject == null)
            {
                //check if a tower is selected
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 1000, 1 << 9 | 1 << 8) && hit.transform.tag == "Tower")
                {
                    ActivateMenu(hit.transform.parent.GetComponent<TowerBase>());
                }
                //deselect tower is the player clicks on empty space
                else
                {
                    UpgradeMenu.gameObject.SetActive(false);
                    areaIndicator.gameObject.SetActive(false);
                }
            }
        }
    }

    /// <summary>
    /// Activate upgrade menu for given tower
    /// </summary>
    /// <param name="newtower"></param>
    void ActivateMenu(TowerBase newtower)
    {
        selectedTower = newtower;

        //Atcivete and position upgrademenu
        UpgradeMenu.gameObject.SetActive(true);
        UpgradeMenu.rectTransform.position = Camera.main.WorldToScreenPoint(selectedTower.transform.position) + new Vector3(140, 0, 0);
        //set menu texts
        nameTxt.text = selectedTower.towerType;
        lvlTxt.text = selectedTower.towerLvl + "";
        //Activate, position and scale tower range indicator
        areaIndicator.position = newtower.transform.position;
        float tempInt = newtower.range * 2;
        areaIndicator.localScale = new Vector3(tempInt, tempInt, tempInt);
        areaIndicator.gameObject.SetActive(true);
        
        //set tooltip texts for the menu buttons
        Upgradetrigger.tooltipText = "Cost: " + newtower.upgradeCost + "Gold";
        selltrigger.tooltipText = "Sell for " + newtower.sellValue + "Gold";
    }
    /// <summary>
    /// Upgrade the selected tower
    /// </summary>
    public void upgradeTower()
    {
        //check if selectedTower has an upgrade cost(if it is upgradeble)
        if (selectedTower.upgradeCost > 0)
        {
            //check if player has enouth gold to upgrade
            if (PlayerDB.Instance.gold >= selectedTower.upgradeCost)
            {
                //deduct gold from played total
                Rman.BuildPayment(selectedTower.upgradeCost);
                //Make/position/rotate the new, upgraded tower
                TowerBase temptower = Instantiate(Resources.Load("Towers/" + selectedTower.towerType + "_lv" + (selectedTower.towerLvl + 1)) as GameObject).GetComponent<TowerBase>();
                temptower.transform.position = selectedTower.transform.position;
                temptower.transform.rotation = selectedTower.transform.rotation;
                temptower.turnTowerOn();
                //remove old tower
                Destroy(selectedTower.gameObject);
                //update the upgrademenu to the new tower
                ActivateMenu(temptower);
                //create buildparticle effect to appear at upgraded tower
                GameObject partemp = Instantiate(buildParticle) as GameObject;
                partemp.transform.position = selectedTower.transform.position;
                partemp.transform.LookAt(selectedTower.transform.position + selectedTower.transform.up);
            }

            
        }
    }
    /// <summary>
    /// Sell and remove selected tower
    /// </summary>
    public void sellTower()
    {
        //add gold to player total
        Rman.AddGold(selectedTower.sellValue);
        //turn off menu
        UpgradeMenu.gameObject.SetActive(false);
        //remove sold tower
        Destroy(selectedTower.gameObject);
        //remove range indicator
        areaIndicator.gameObject.SetActive(false);
        //manualy turn off currently displaying tooltip(or it will remain after clicking)
        gameObject.GetComponent<TooltipControl>().turnOff();
    }
}
