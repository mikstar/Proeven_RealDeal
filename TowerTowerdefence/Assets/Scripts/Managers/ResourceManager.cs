using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ResourceManager : MonoBehaviour {

    public Image healthGUI;             
    public PlayerDB playerDB;
    public GameControl gameControl;

    /// <summary>
    /// Inflicts damage on player healthpoints
    /// </summary>
    public void BaseTakeDMG(int dmg) {
        PlayerDB.Instance.health -= dmg;

        //If player health point drop below 0 the game is over
        if (PlayerDB.Instance.health <= 0)
        {
            PlayerDB.Instance.health = 0;
            gameControl.GameOver();
        }
    }

    /// <summary>
    /// Takes gold from player 'gold' resource'.
    /// </summary>
    public void BuildPayment(int cost)
    {
        PlayerDB.Instance.gold -=cost;
    }

    /// <summary>
    /// Adds gold to player 'gold' resource.
    /// </summary>
    public void AddGold(int reward) {
        PlayerDB.Instance.gold += reward;
    }
}
