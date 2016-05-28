using UnityEngine;
using System.Collections;

public class WaveManager : MonoBehaviour {

    public int startDelay;
    public int waveDelay;

    private WaveDB waveDB;
    private SpawnManager spawnManager;
    private bool wavePause;

    private int currentEnemy;
    private int enemiesSpawning;

    private AudioManager audioManager;
    private AudioSource asource;

    void Start() {
        waveDB          =   GameObject.FindGameObjectWithTag("GameController").GetComponent<WaveDB>();
        spawnManager    =   GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManager>();
        audioManager    =   GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();

        
    }

    void Update() {
        if (!wavePause && (waveDB.currentWave % 5) == 0){
            waveDB.waveTimer = startDelay;
            wavePause = true;
        }
    }

    //TO DO: functies hier onder aanpassen/verplaatsen
    public void NextWaveButtonClicked() {
        if (!waveDB.isSpawning) {
            waveDB.waveTimer = 0;
        }
    }

    public void StartGameButtonClicked() {
        StartCoroutine("SpawnTimer");
    }

    void StartNewWave() {
        audioManager.PlayNewWave();

        currentEnemy = 0;
        waveDB.currentWave++;

        enemiesSpawning = waveDB.waves[waveDB.currentWave - 1].enemies.Length - 1;
        waveDB.isSpawning = true;
        StartCoroutine("SpawnEnemies");
    }

    IEnumerator SpawnTimer() {
        waveDB.waveTimer = waveDelay;

        while (true) {
            if (waveDB.waveTimer > 0) {
                yield return new WaitForSeconds(1);
                waveDB.waveTimer--;
            }
            else{
                wavePause = false;
                StartNewWave();
                break;
            }
        }
    }

    IEnumerator SpawnEnemies() {
        while (true) {
            yield return new WaitForSeconds(waveDB.waves[waveDB.currentWave - 1].spawnDelay);
            if (enemiesSpawning >= 0){
                currentEnemy++;
                enemiesSpawning--;

                WaveDB.EnemyData spawnInfo = waveDB.waves[waveDB.currentWave - 1].enemies[currentEnemy - 1];

                int pathNum = (int)spawnInfo.path;

                spawnManager.SpawnEnemy(spawnInfo.name.ToString(),pathNum, spawnInfo.size.ToString(), spawnInfo.speed, spawnInfo.health);
            }
            else {
                waveDB.isSpawning = false;
                StartCoroutine("SpawnTimer");
                break;
            }
        }
    }
}
