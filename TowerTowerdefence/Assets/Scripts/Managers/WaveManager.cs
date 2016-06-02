﻿using UnityEngine;
using System.Collections;

public class WaveManager : MonoBehaviour {

    [Header("Wave timers")]
    public int startDelay;
    public int waveDelay;

    private WaveDB waveDB;
    private SpawnManager spawnManager;
    private bool wavePause;

    private int currentEnemy;
    private int enemiesSpawning;

    private AudioManager  audioManager;
    private AudioSource  asource;

    void Start()
    {
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

    public void NextWave()
    {
        if (!waveDB.isSpawning)
        {
            waveDB.waveTimer = 0;
        }
    }

    public void StartGameButtonClicked()
    {
        StartCoroutine("SpawnTimer");
    }

    public void StopWaves()
    {
        StopCoroutine("SpawnTimer");
        StopCoroutine("SpawnEnemies");
    }

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
