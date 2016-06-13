using UnityEngine;
using System.Collections;

public class WaveManager : MonoBehaviour {

    [Header("Wave timers")]
    public int startDelay;                      //delay before the first wave starts
    public int waveDelay;                       //delat before the next wave starts

    private WaveDB waveDB;                      //wave data
    private SpawnManager spawnManager;          //Spawn manager
    private bool wavePause;             

    private AudioManager  audioManager;         //Audio Manager
    private AudioSource  asource;               //Audio source
    
    private int currentEnemy;
    private int enemiesSpawning;

    void Start()
    {
        //Getting all managers
        waveDB          =   GameObject.FindGameObjectWithTag("GameController").GetComponent<WaveDB>();
        spawnManager    =   GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManager>();
        audioManager    =   GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
    }

    void Update()
    {
        //Check if wave can start
        if (!wavePause && (waveDB.currentWave % 5) == 0)
        {    
            waveDB.waveTimer = startDelay;
            wavePause = true;
        }
    }

    /// <summary>
    /// Sets the wavetimer to 0 in order to make the next wave spawn immediately
    /// </summary>
    public void NextWave()
    {
        //If there is no wave currently in spawn
        if (!waveDB.isSpawning)
        {
            //Set the timer to zero to make the next wave spawn
            waveDB.waveTimer = 0;
        }
    }

    /// <summary>
    /// Starts the game by starting the spawning coroutine
    /// </summary>
    public void StartGameButtonClicked()
    {
        StartCoroutine("SpawnTimer");
    }

    /// <summary>
    /// Stops the game by stopping the spawning coroutine
    /// </summary>
    public void StopWaves()
    {
        StopCoroutine("SpawnTimer");
        StopCoroutine("SpawnEnemies");
    }

    /// <summary>
    /// Starts a new wave
    /// </summary>
    void StartNewWave()
    {
        //Play audio for new incoming wave
        audioManager.PlayNewWave();

        //Start at enemy 0
        currentEnemy = 0;

        //Update current wave
        waveDB.currentWave++;

        enemiesSpawning     =   waveDB.waves[waveDB.currentWave - 1].enemies.Length - 1;
        waveDB.isSpawning   =   true;
        StartCoroutine("SpawnEnemies");
    }


    IEnumerator SpawnTimer()
    {
        waveDB.waveTimer = waveDelay;

        while (true) {
            if (waveDB.waveTimer > 0)
            {
                yield return new WaitForSeconds(1);
                waveDB.waveTimer--;
            }
            else
            {
                wavePause = false;
                StartNewWave();
                break;
            }
        }
    }

    IEnumerator SpawnEnemies()
    {
        while (true) {
            yield return new WaitForSeconds(waveDB.waves[waveDB.currentWave - 1].spawnDelay);
            if (enemiesSpawning >= 0)
            {
                currentEnemy++;
                enemiesSpawning--;

                WaveDB.EnemyData spawnInfo = waveDB.waves[waveDB.currentWave - 1].enemies[currentEnemy - 1];

                int pathNum = (int)spawnInfo.path;

                spawnManager.SpawnEnemy(spawnInfo.name.ToString(),pathNum, spawnInfo.size.ToString(), spawnInfo.speed, spawnInfo.health);
            }
            else
            {
                waveDB.isSpawning = false;
                StartCoroutine("SpawnTimer");
                break;
            }
        }
    }
}
