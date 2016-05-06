using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour {

    public PlayerDB baseHealth;
    public Image healthGUI;

    void FixedUpdate() {
        healthGUI.fillAmount = baseHealth.health / 10f;
       
    }
}
