using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

    public Transform spawnPosition;
    public GameObject[] paths;
    public GameObject myPath;
    public ResourceManager rM;

    private GameObject enemy;

	void Start () {
	
	}

    public void SpawnEnemy(string name, int path, string size, float speed, float health) {
        switch (path) {
            case 0:
                myPath = paths[0];
                break;
            case 1:
                myPath = paths[1];
                break;
            case 2:
                myPath = paths[3];
                break;
        }

        enemy = Instantiate(Resources.Load("Prefabs/Enemies/" + name), spawnPosition.position, Quaternion.identity) as GameObject;

        EnemyBase eb = enemy.GetComponent<EnemyBase>();
        eb.health = health;
        eb.speed = speed;
        eb.sManager = this;
        eb.rManager = rM;
        eb.path = myPath;
        
    }
}
