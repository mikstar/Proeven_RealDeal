using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ResourceManager : MonoBehaviour {

    public Image healthGUI;
    public PlayerDB playerDB;

    public void BaseTakeDMG() {
        PlayerDB.Instance.health--;
        healthGUI.fillAmount = PlayerDB.Instance.health / PlayerDB.Instance.startHealth;
    }

    public void BuildPayment(int cost) {
        PlayerDB.Instance.gold -= cost;
    }
}
