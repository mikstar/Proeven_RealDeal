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
    
    /// <summary>
    /// Reactivate bulled
    /// </summary>
    public void turnOn()
    {
        isActive = true;
        //Turn on mesh
        bullModel.SetActive(true);
        //Turn on particle effect to make it start emitting again
        trail.Play();
    }
    /// <summary>
    /// Deactivate bulled(does not destroy for later use)
    /// </summary>
    public void turnOff()
    {
        isActive = false;
        //remove current target
        target = null;
        //Turn off mesh
        bullModel.SetActive(false);
        //Stop particle effect from emittion, previously emittet particles will persist
        trail.Stop();
    }
    /// <summary>
    /// Set bullets stats
    /// </summary>
    /// <param name="tar"></param>
    /// <param name="spd"></param>
    /// <param name="dmg"></param>
    public void setStats(Transform tar,float spd,float dmg)
    {
        explosion.Stop();
        target = tar;
        speed = spd;
        damage = dmg;
    }
	
	// Update is called once per frame
	void Update () {
        //Check if there is a target
        if (target != null)
        {
            //check if bullet has reached target
            if (Vector3.Distance(transform.position,target.position) < 0.5f)
            {
                //apply damage to enemy
                target.gameObject.GetComponent<EnemyBase>().DamageEnemy(damage);
                //play explosion effect
                explosion.Play();

                turnOff();
            }
            else
            {
                //rotate to/move towards target
                transform.LookAt(target);
                transform.position += transform.forward * speed;
            }
        }
        //If target is removed before bullet reaches it, deactivate bullet
        else if(isActive)
        {
            turnOff();
        }
	}
}
