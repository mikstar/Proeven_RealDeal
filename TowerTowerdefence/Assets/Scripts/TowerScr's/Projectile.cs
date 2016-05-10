using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    private Transform target;
    private float speed;
    private float damage;

    public void setStats(Transform tar,float spd,float dmg)
    {
        target = tar;
        speed = spd;
        damage = dmg;
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(transform.position,target.position) < 0.5f)
        {
            target.gameObject.GetComponent<EnemyBase>().DamageEnemy(damage);
            gameObject.SetActive(false);
        }

        transform.LookAt(target);
        transform.position += transform.forward * speed;
	}
}
