using UnityEngine;
using System.Collections;

public class TwoAxisTurrent : MonoBehaviour {
    //...
    // script to alighn a towers base and barrel with the direction that it's firing at
    //...
    
    //tower base to alighn
    public Transform platform;
    //tower barrel to alighn
    public Transform cannon;
    
    private TowerBase towerSrc;

    // Use this for initialization
    void Start () {
        //save the towers base script to access its targeting later
        towerSrc = GetComponent<TowerBase>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        //check if there are any targets
        if (towerSrc.targets.Count != 0)
        {
            //check if the target is alive and still existant
            if(towerSrc.targets[0] != null && towerSrc.targets[0].GetComponent<EnemyBase>().isDead == false)
            {
                //make barrel look at target directly
                cannon.LookAt(towerSrc.targets[0].transform, platform.up);
                //make the base only rotate towards the target in the y direction
                platform.localEulerAngles = new Vector3(platform.localEulerAngles.x, cannon.localEulerAngles.y, platform.localEulerAngles.z);
            }
        }
    }
}
