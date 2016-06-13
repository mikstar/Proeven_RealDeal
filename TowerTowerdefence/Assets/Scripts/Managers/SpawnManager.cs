using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

    [SerializeField] private Transform spawnPosition;   //Position enemies will spawn from
    [SerializeField] private GameObject[] paths;        //Array of paths the enemy can walk on
    [SerializeField] private ResourceManager rM;        //Resource manager
    [SerializeField] private AudioManager aM;           //Audio manager

    private GameObject myPath;                          //Chosen path to walk on
    private GameObject enemy;

    /// <summary>
    /// Creates an enemy and assigns it's properties.
    /// </summary>
    public void SpawnEnemy(string name, int path, string size, float speed, float health)
    {
        switch (path)
        {
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

        //Get enemy prefab
        enemy = Instantiate(Resources.Load("Prefabs/Enemies/" + name), spawnPosition.position, Quaternion.identity) as GameObject;

        //Get EnemyBase script, set managers and path 
        EnemyBase eb    =   enemy.GetComponent<EnemyBase>();
        eb.sManager     =   this;
        eb.rManager     =   rM;
        eb.aManager     =   aM;
        eb.path         =   myPath;
        
    }
}
