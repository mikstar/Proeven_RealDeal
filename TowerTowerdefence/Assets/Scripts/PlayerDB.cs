using UnityEngine;
using System.Collections;

public class PlayerDB : MonoBehaviour {

    private static PlayerDB instance = null;
    
    public int gold;
    public int health;
    public int startHealth;

    public static PlayerDB Instance {
        get {
            if (instance = null) {
                instance = FindObjectOfType(typeof(PlayerDB)) as PlayerDB;
            }
            if (instance = null) {
                GameObject go = new GameObject("PlayerDB");
                instance = go.AddComponent(typeof(PlayerDB)) as PlayerDB;
            }

            return instance;
        }
    }
}
