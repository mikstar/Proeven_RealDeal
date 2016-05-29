using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {


    public GameObject gameoverscreen;
    public AudioManager aManager;
    public WaveManager wManager;

    private bool gameFinished ;

    void Start() {
        gameFinished = false;
    }

    public void GameOver() {
        if (!gameFinished)
        {
            gameFinished = true;
            aManager.PlayGameOver();
            gameoverscreen.SetActive(true);

            wManager.StopWaves();
        }
    }

    public void GameWon() {

    }
}
