using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    public Text resourceCount;          //Text to display gold
    public Text waveCount;              //Text to display current wave
    public Text startTimer;             //Text to display time in seconds till next wave
    public Text healtCount;             //Text to display healthpoints

    public Button nextWaveButton;       //Button to skip to next wave

    public bool HUDactive;              

    private WaveManager waveManager;    //Wave Manager
    private WaveDB waveDB;              //Wave data

    void Start()
    {
        waveManager =   GameObject.FindGameObjectWithTag("GameController").GetComponent<WaveManager>();
        waveDB      =   GameObject.FindGameObjectWithTag("GameController").GetComponent<WaveDB>();

        HUDactive   =   false;
    }

    void FixedUpdate()
    {
        //Set the text elements
        resourceCount.text  =   PlayerDB.Instance.gold.ToString();

        healtCount.text     =   PlayerDB.Instance.health.ToString() + "/" + PlayerDB.Instance.maxHealth.ToString();

        waveCount.text      =   "Wave: " + waveDB.currentWave.ToString();

        if (waveDB.isSpawning == true)
        {
            startTimer.text = "Wave in progress";
            nextWaveButton.gameObject.SetActive(false);
        }

        else
        {
            startTimer.text = "Next wave in " + waveDB.waveTimer.ToString() + " seconds";
            if (HUDactive == true)
            {
                nextWaveButton.gameObject.SetActive(true);
            }
        } 
    }

    public void NextWaveButtonClicked()
    {
        //Function for next wave
        waveManager.NextWave();   
    }

   
    public void RestartLevel() {
        Application.LoadLevel("ForestDay");
    }

    public void BackToMenu() {
        Application.LoadLevel("MenuScene");
    }
}
