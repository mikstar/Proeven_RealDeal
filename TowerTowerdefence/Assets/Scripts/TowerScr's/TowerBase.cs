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
    //list of all current targets
    public List<GameObject> targets = new List<GameObject>();
    //time untill turrent fires next
    protected float timeToFire;

    protected AudioSource audioSRS;

	// Use this for initialization
	void Start () {
        //set delay intil turrent fires next
        timeToFire = 60 / firerate;
        //set range
        rangeColl.radius = range;
        //save audiosource for later use
        audioSRS = GetComponent<AudioSource>();
    }
    /// <summary>
    /// Enable tower when placed(mostly redundant)
    /// </summary>
    public void turnTowerOn()
    {
        rangeColl.enabled = true;
        baseColl.enabled = true;
    }
	
    void OnTriggerEnter(Collider col)
    {
        //If enemy enters range collider
        if (col.gameObject.tag == "Enemy")
        {
            //add enemy to target list
            targets.Add(col.gameObject);
        }
    }
    void OnTriggerExit(Collider col)
    {
        //If enemy leaves range collider
        if (col.gameObject.tag == "Enemy")
        {
            //remove enemy from target list
            targets.Remove(col.gameObject);
        }
    }

    /// <summary>
    /// Fire the turrent(To be defined in child classed)
    /// </summary>
    protected virtual void fireTurrent()
    {
        
    }

    // Update is called once per frame
    void Update () {
        //If tower has any targets
        if (targets.Count != 0)
        {
            //count down till next fire
            timeToFire -= Time.deltaTime;
            if (timeToFire<=0)
            {
                //reset fire countdown
                timeToFire = 60 / firerate;
                
                fireTurrent();
            }
        }
    }
}
