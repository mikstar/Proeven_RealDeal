using UnityEngine;
using System.Collections;

public class TurrentLightning : TowerBase{

    //public float damage;
    //public float firerate;//shots per minute
    //public float range;

    //private GameObject[] targets;

    protected override void fireTurrent()
    {
        for (int i=0;i>targets.Count; i++)
        {
            targets[i].GetComponent<EnemyBase>().DamageEnemy(damage);
        }
    }
}
