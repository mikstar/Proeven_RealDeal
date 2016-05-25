using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    private Transform target;
    private float speed;
    private float damage;
    private TowerBase sourceTower;
    

    public void setStats(Transform tar,float spd,float dmg)
    {
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
                gameObject.SetActive(false);
            }
            else
            {
                transform.LookAt(target);
                transform.position += transform.forward * speed;
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
	}
}
