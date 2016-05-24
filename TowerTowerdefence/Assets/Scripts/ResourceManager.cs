using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ResourceManager : MonoBehaviour {
    public Image healthGUI;
    public PlayerDB playerDB;

    public void BaseTakeDMG(int dmg) {
        PlayerDB.Instance.health -= dmg;
        healthGUI.fillAmount = PlayerDB.Instance.health / PlayerDB.Instance.startHealth;
    }

    public void BuildPayment(int cost) {
        PlayerDB.Instance.gold -= cost;
    }

    public void AddGold(int reward) {
        PlayerDB.Instance.gold += reward;
    }
}
