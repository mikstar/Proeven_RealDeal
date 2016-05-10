using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour {
    
    //TO DO: clean up, dirty
     
    public PlayerDB baseHealth;
    public Image healthGUI;

    void FixedUpdate() {
        healthGUI.fillAmount = baseHealth.health / baseHealth.startHealth;
    }
}
