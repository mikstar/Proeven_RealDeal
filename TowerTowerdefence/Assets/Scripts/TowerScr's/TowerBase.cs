using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TowerBase : MonoBehaviour {
    
    public float damage;
    public float firerate;//shots per minute
    public float range;

    //private GameObject[] targets;
    public List<GameObject> targets = new List<GameObject>();
    private float timeToFire;

	// Use this for initialization
	void Start () {
        timeToFire = 60 / firerate;
        gameObject.GetComponent<SphereCollider>().radius = range;
    }
	
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            targets.Add(col.gameObject);
            Debug.Log("TargetEnter");
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            targets.Remove(col.gameObject);
            Debug.Log("TargetExit");
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
