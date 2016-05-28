using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {


    //TO DO: clean up
    public Transform spawnPosition;
    public GameObject[] paths;
    public GameObject myPath;
    public ResourceManager rM;
    public AudioManager aM;

    private GameObject enemy;

    public void SpawnEnemy(string name, int path, string size, float speed, float health) {
        switch (path) {
            case 0:
                myPath = paths[0];
                break;
            case 1:
                myPath = paths[1];
                break;
            case 2:
                myPath = paths[2];
                break;
        }

        enemy = Instantiate(Resources.Load("Prefabs/Enemies/" + name), spawnPosition.position, Quaternion.identity) as GameObject;

        EnemyBase eb = enemy.GetComponent<EnemyBase>();
        eb.sManager = this;
        eb.rManager = rM;
        eb.aManager = aM;
        eb.path = myPath;
        
    }
}
