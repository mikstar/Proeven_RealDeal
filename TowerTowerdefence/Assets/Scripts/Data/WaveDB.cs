﻿using UnityEngine;
using System.Collections;

public class WaveDB : MonoBehaviour {
    [HideInInspector] public int currentWave = 0;
    [HideInInspector] public int waveTimer = 0;
    [HideInInspector] public bool isSpawning = false;

    [System.Serializable]
    public class Row{
        public float spawnDelay;
        public EnemyData[] enemies;
    };

    [System.Serializable]
    public class EnemyData{
        public enum EnemyTypes{
            ShroomNormal,
            ShroomTank,
            Herbo, 
            Boss, 
            Boss2
        };
        public enum EnemyPath{
            Green,
            Red,
            Blue
        };
        public enum EnemySize{
            Small,
            Meduim, 
            Large
        };

        public EnemyTypes   name;
        public EnemyPath    path;
        public EnemySize    size;

        [Header("Stats")]
        public float        speed;
        public float        health; 

    };

    public Row[] waves = new Row[5];


}
