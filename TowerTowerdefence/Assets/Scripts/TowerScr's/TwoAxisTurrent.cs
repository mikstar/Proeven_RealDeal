using UnityEngine;
using System.Collections;

public class TwoAxisTurrent : MonoBehaviour {

    public Transform platform;
    public Transform cannon;

    public Transform target;
    public Transform upObj;
    private TowerBase towerSrc;

    // Use this for initialization
    void Start () {
        towerSrc = GetComponent<TowerBase>();
        if (upObj == null)
        {
            upObj = transform;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (towerSrc.targets.Count != 0)
        {
            if(towerSrc.targets[0] != null && towerSrc.targets[0].GetComponent<EnemyBase>().isDead == false)
            {
                cannon.LookAt(towerSrc.targets[0].transform, platform.up);
                platform.localEulerAngles = new Vector3(platform.localEulerAngles.x, cannon.localEulerAngles.y, platform.localEulerAngles.z);
            }
        }
    }
}
