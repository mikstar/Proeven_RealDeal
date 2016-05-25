using UnityEngine;
using System.Collections;

public class TempMainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void StartGame() {
        Application.LoadLevel("ForestDay");
    }

    public void ExitGame() {
        Application.Quit();
    }

    public void SelectLevel() {

    }
}
