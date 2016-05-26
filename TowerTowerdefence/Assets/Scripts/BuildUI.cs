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
	
    public void setNextBuy(int price)
    {
        nextBuy = price;
    }

    public void giveTower(string name)
    {
        if (PlayerDB.Instance.gold >= nextBuy)
        {
            placerSrc.holdNewObj(Instantiate(Resources.Load("Towers/" + name)) as GameObject, nextBuy);
        }
    }

	// Update is called once per frame
	void Update () {

	}
}
