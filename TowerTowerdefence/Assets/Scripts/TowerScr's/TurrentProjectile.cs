using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TurrentProjectile : TowerBase {

    //public float damage;
    //public float firerate;//shots per minute
    //public float range;
    public float bulletSpeed;
    public Transform firepoint;
    public GameObject bulletPrefab;

    //private GameObject[] targets;
    private List<Projectile> bullets = new List<Projectile>();

    protected override void fireTurrent()
    {
        
        while(targets[0].GetComponent<EnemyBase>().isDead)
        {
            targets.RemoveAt(0);
            if (targets.Count == 0)
            {
                timeToFire = 0;
                return;
            }
        }
        
        //Check if a bullet is avalible
        int AvalibleBulletIndx = -1;
        for (int i=0;i< bullets.Count; i++)
        {
            if (bullets[i].isActive == false)
            {
                AvalibleBulletIndx = i;
                i = bullets.Count;
            }
        }

        if (AvalibleBulletIndx > -1)
        {
            //use avalible bullet
            bullets[AvalibleBulletIndx].transform.position = firepoint.position;
            bullets[AvalibleBulletIndx].transform.rotation = firepoint.rotation;
            bullets[AvalibleBulletIndx].GetComponent<Projectile>().setStats(targets[0].transform, bulletSpeed, damage);
            bullets[AvalibleBulletIndx].turnOn();


        }
        else
        {
            //make new bullet
            GameObject newBull =  Instantiate(bulletPrefab, firepoint.position, Quaternion.identity) as GameObject;
            newBull.transform.rotation = firepoint.rotation;
            newBull.GetComponent<Projectile>().setStats(targets[0].transform, bulletSpeed, damage);
            bullets.Add(newBull.GetComponent<Projectile>());
        }
    }
}
