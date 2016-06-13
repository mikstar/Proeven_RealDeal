using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {


    public GameObject gameoverscreen;       //UI screen shown when the game is over.
    public AudioManager aManager;           //Audio manager
    public WaveManager wManager;            //Wave manager

    private bool gameFinished;

    void Start()
    {
        gameFinished = false;
    }

    /// <summary>
    /// Stops all waves and spawns game over screen.
    /// </summary>
    public void GameOver()
    {
        if (!gameFinished)
        {
            gameFinished = true;
            aManager.PlayGameOver();
            gameoverscreen.SetActive(true);

            wManager.StopWaves();
        }
    }

    public void GameWon()
    {

    }
}
