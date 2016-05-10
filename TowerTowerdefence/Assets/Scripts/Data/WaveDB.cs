using UnityEngine;
using System.Collections;

public class WaveDB : MonoBehaviour {

    public int currentWave = 0;
    public int waveTimer = 0;
    public bool isSpawning = false;

    [System.Serializable]
    public class Row{
        public float spawnDelay;
        public EnemyData[] enemies;
    };

    [System.Serializable]
    public class EnemyData{
        public enum EnemyTypes{
            Shroom1,
            Shroom2,
            Herbo
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
        public enum EnemySpeed{
            Slow,
            Normal,
            Fast
        };

        public EnemyTypes   name;
        public EnemyPath    path;
        public EnemySpeed   testspeed;
        public EnemySize    size;
        public float        speed;
        public float        health; 

    };

    public Row[] waves = new Row[5];


}
