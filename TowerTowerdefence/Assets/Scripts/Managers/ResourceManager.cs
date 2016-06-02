﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ResourceManager : MonoBehaviour {
    public Image healthGUI;
    public PlayerDB playerDB;
    public GameControl gameControl;
    

    public void BaseTakeDMG(int dmg) {
        PlayerDB.Instance.health -= dmg;

        //TEMP!!! 
        if (PlayerDB.Instance.health <= 0) {
            PlayerDB.Instance.health = 0;
            gameControl.GameOver();
        }
    }

    public void BuildPayment(int cost)
    {
        PlayerDB.Instance.gold -=cost;
    }

    public void AddGold(int reward) {
        PlayerDB.Instance.gold += reward;
    }
}
