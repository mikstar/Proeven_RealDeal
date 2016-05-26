using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    public Text resourceCount;
    public Text waveCount;
    public Text startTimer;
    public Text healtCount;

    public Button nextWaveButton;

    private WaveManager waveManager;
    private WaveDB waveDB;

    void Start() {
        waveManager =   GameObject.FindGameObjectWithTag("GameController").GetComponent<WaveManager>();
        waveDB      =   GameObject.FindGameObjectWithTag("GameController").GetComponent<WaveDB>();
        //nextWaveButton.onClick.AddListener(() => NextWaveButtonClicked());
    }

    void FixedUpdate() {
        resourceCount.text  =   PlayerDB.Instance.gold.ToString();

        healtCount.text     =   PlayerDB.Instance.health.ToString() + "/" + PlayerDB.Instance.startHealth.ToString();

        waveCount.text      =   "Wave: " + waveDB.currentWave.ToString();

        if (waveDB.isSpawning == true)
        {
            startTimer.text = "Wave in progress";
        }
        else {
            startTimer.text = "Next wave in " + waveDB.waveTimer.ToString() + " seconds";
        } 
    }

    private void NextWaveButtonClicked() {
        waveManager.NextWaveButtonClicked();
    }

    //TEMP CODE BELOW
    public void RestartLevel() {
        Application.LoadLevel("ForestDay");
    }

    public void BackToMenu() {
        Application.LoadLevel("MenuScene");
    }
}
