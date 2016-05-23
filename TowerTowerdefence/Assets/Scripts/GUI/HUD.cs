using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    public Text resourceCount;
    public Text waveCount;
    public Text startTimer;
    public Text healtCount;

    public Button nextWaveButton;

    public WaveManager waveManager;
    public WaveDB waveDB;

    void Start() {
        waveManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<WaveManager>();
        waveDB = GameObject.FindGameObjectWithTag("GameController").GetComponent<WaveDB>();
        //nextWaveButton.onClick.AddListener(() => NextWaveButtonClicked());
    }

    void FixedUpdate() {
        resourceCount.text = PlayerDB.Instance.gold.ToString();
        healtCount.text = PlayerDB.Instance.health.ToString() + "/" + PlayerDB.Instance.startHealth.ToString();
        //waveCount.text =
        //startTimer.text = waveDB.waveTimer.ToString();
    }

    private void NextWaveButtonClicked() {
        waveManager.NextWaveButtonClicked();
    }
}
