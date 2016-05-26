using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    private Transform target;
    private float speed;
    private float damage;
    private TowerBase sourceTower;

    public GameObject bullModel;
    public ParticleSystem trail;
    public ParticleSystem explosion;

    public bool isActive;
    
    public void turnOn()
    {
        isActive = true;
        bullModel.SetActive(true);
        trail.Play();
    }
    public void turnOff()
    {
        isActive = false;
        target = null;
        bullModel.SetActive(false);
        trail.Stop();
    }

    public void setStats(Transform tar,float spd,float dmg)
    {
        explosion.Stop();
        target = tar;
        speed = spd;
        damage = dmg;
    }
	
	// Update is called once per frame
	void Update () {
        if (target != null)
        {
            if (Vector3.Distance(transform.position,target.position) < 0.5f)
            {
                target.gameObject.GetComponent<EnemyBase>().DamageEnemy(damage);
                explosion.Play();
                turnOff();
            }
            else
            {
                transform.LookAt(target);
                transform.position += transform.forward * speed;
            }
        }
        else if(isActive)
        {
            turnOff();
        }
	}
}
