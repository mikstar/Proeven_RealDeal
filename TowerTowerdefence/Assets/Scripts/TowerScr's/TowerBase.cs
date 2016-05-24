using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TowerBase : MonoBehaviour {

    public string towerType;
    public int towerLvl;

    public float damage;
    public float firerate;//shots per minute
    public float range;

    public int sellValue;
    public int upgradeCost;

    public SphereCollider rangeColl;
    public SphereCollider baseColl;

    //private GameObject[] targets;
    public List<GameObject> targets = new List<GameObject>();
    protected float timeToFire;

	// Use this for initialization
	void Start () {
        timeToFire = 60 / firerate;
        rangeColl.radius = range;
    }

    public void turnTowerOn()
    {
        rangeColl.enabled = true;
        baseColl.enabled = true;
    }
	
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            targets.Add(col.gameObject);
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            targets.Remove(col.gameObject);
        }
    }
    protected virtual void fireTurrent()
    {

    }

    // Update is called once per frame
    void Update () {
        if (targets.Count != 0)
        {
            timeToFire -= Time.deltaTime;
            if (timeToFire<=0)
            {
                timeToFire = 60 / firerate;
                fireTurrent();
            }
        }
    }
}
