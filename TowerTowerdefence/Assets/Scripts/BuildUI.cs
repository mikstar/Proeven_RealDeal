using UnityEngine;
using System.Collections;

public class BuildUI : MonoBehaviour {

    private TowerPlacer placerSrc;

	// Use this for initialization
	void Start () {
        placerSrc = GetComponent<TowerPlacer>();
	}
	
    public void giveTower(string name)
    {
        placerSrc.holdNewObj(Instantiate(Resources.Load("Tower")) as GameObject);
    }

	// Update is called once per frame
	void Update () {
	
	}
}
