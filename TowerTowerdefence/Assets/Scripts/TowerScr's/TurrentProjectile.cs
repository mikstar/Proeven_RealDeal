using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TurrentProjectile : TowerBase {

    public float bulletSpeed;
    public Transform firepoint;
    public GameObject bulletPrefab;

    //list of all fired used bullets
    private List<Projectile> bullets = new List<Projectile>();

    protected override void fireTurrent()
    {
        //check if the first enemy in the list is dead or removed, repeat until a live target is found
        while (targets[0] == null || targets[0].GetComponent<EnemyBase>().isDead)
        {
            targets.RemoveAt(0);
            //if no live targets are present, set time to next fire back to 0 an cancel the fireing
            if (targets.Count == 0)
            {
                timeToFire = 0;
                return;
            }
        }

        //play fireing audio
        audioSRS.Play();

        //Check if a non-active bullet is avalible
        int AvalibleBulletIndx = -1;
        for (int i=0;i< bullets.Count; i++)
        {
            //if bullet is not active save its index and stop this loop
            if (bullets[i].isActive == false)
            {
                AvalibleBulletIndx = i;
                i = bullets.Count;
            }
        }

        //if there was any avalible bullet
        if (AvalibleBulletIndx > -1)
        {
            //use avalible bullet
            //move/rotate it to the firepoint, set its new target and re-activate it
            bullets[AvalibleBulletIndx].transform.position = firepoint.position;
            bullets[AvalibleBulletIndx].transform.rotation = firepoint.rotation;
            bullets[AvalibleBulletIndx].GetComponent<Projectile>().setStats(targets[0].transform, bulletSpeed, damage);
            bullets[AvalibleBulletIndx].turnOn();


        }
        //if there were no avalible bullets 
        else
        {
            //make new bullet
            GameObject newBull =  Instantiate(bulletPrefab, firepoint.position, Quaternion.identity) as GameObject;
            newBull.transform.rotation = firepoint.rotation;
            //set all stats for new bullet
            newBull.GetComponent<Projectile>().setStats(targets[0].transform, bulletSpeed, damage);
            //add new bullet to list of used bullets for later use
            bullets.Add(newBull.GetComponent<Projectile>());
        }
    }
}
