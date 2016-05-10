using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    public Text resourceCount;
    public Text waveCount;

    public Button nextWaveButton;

    public WaveManager waveManager;

    void Start() {
        waveManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<WaveManager>();

        nextWaveButton.onClick.AddListener(() => NextWaveButtonClicked());
    }

    void FixedUpdate() {
        //resourceCount.text =
        //waveCount.text =
    }

    private void NextWaveButtonClicked() {
        waveManager.NextWaveButtonClicked();
    }
}
