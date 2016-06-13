using UnityEngine;
using System.Collections;

public class PlayerDB : MonoBehaviour {

    private static PlayerDB instance = null;
    
    public int gold;                //The players 'gold' resource
    public float health;            //The players health points
    public float maxHealth;         //Maximum amount of health point 


    /// <summary>
    /// Instance of Player data
    /// </summary>
    public static PlayerDB Instance {
        get {
            if (instance == null) {
                instance = FindObjectOfType(typeof(PlayerDB)) as PlayerDB;
            }
            if (instance == null) {
                GameObject go = new GameObject("PlayerDB");
                instance = go.AddComponent(typeof(PlayerDB)) as PlayerDB;
            }
            return instance;
        }
    }
}
