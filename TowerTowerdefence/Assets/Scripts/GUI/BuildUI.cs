using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class BuildUI : MonoBehaviour {

    private TowerPlacer placerSrc;

    private int nextBuy;

	// Use this for initialization
	void Start () {
        placerSrc = GetComponent<TowerPlacer>();
	}
	
    //seperate function to set price of next purchase(to allow several variables to be given by a single UI button)
    public void setNextBuy(int price)
    {
        nextBuy = price;
    }

    /// <summary>
    /// make a new tower of the given type, and give it to the towerplacer script. (setNextBuy should always be called before this one)
    /// </summary>
    /// <param name="name"></param>
    public void giveTower(string name)
    {
        //check is player can afford
        if (PlayerDB.Instance.gold >= nextBuy)
        {
            placerSrc.holdNewObj(Instantiate(Resources.Load("Towers/" + name)) as GameObject, nextBuy);
        }
    }
}
