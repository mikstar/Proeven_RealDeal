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
    private List<GameObject> bullets = new List<GameObject>();

    protected override void fireTurrent()
    {
        //Check if a bullet is avalible
        int AvalibleBulletIndx = -1;
        for (int i=0;i< bullets.Count; i++)
        {
            if (bullets[i].activeSelf == false)
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
            bullets[AvalibleBulletIndx].GetComponent<Projectile>().setStats(targets[targets.Count-1].transform, bulletSpeed, damage);
            bullets[AvalibleBulletIndx].SetActive(true);


        }
        else
        {
            //make new bullet
            GameObject newBull =  Instantiate(bulletPrefab, firepoint.position, Quaternion.identity) as GameObject;
            newBull.transform.rotation = firepoint.rotation;
            newBull.GetComponent<Projectile>().setStats(targets[targets.Count - 1].transform, bulletSpeed, damage);
            bullets.Add(newBull);
        }
    }
}
