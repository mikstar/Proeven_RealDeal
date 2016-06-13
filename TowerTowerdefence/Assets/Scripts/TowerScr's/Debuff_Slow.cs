using UnityEngine;
using System.Collections;

public class Debuff_Slow : MonoBehaviour {
    //...
    //Script to be apply'd to enemy's to add slowing effect
    //...

    private float timeLeft;
    private float fullSpd;
    private EnemyBase enmSrc;
    
    /// <summary>
    /// Set slow ammount and effect duration and start effect
    /// </summary>
    /// <param name="spdChnge"></param>
    /// <param name="duration"></param>
    public void setStatsAndStart(float spdChnge, float duration)
    {
        timeLeft = duration;
        //save enemy's original speed
        enmSrc = GetComponent<EnemyBase>();
        fullSpd = enmSrc.speed;
        //set new speed
        enmSrc.speed = enmSrc.speed * spdChnge;
    }
    /// <summary>
    /// Reset effect duration
    /// </summary>
    /// <param name="duration"></param>
    public void setStatsAndReset(float duration)
    {
        timeLeft = duration;
    }

    // Update is called once per frame
    void Update () {
        //reduce time left
        timeLeft -= Time.deltaTime;
        //if times runs out
        if (timeLeft < 0)
        {
            //set back to original speed
            enmSrc.speed = fullSpd;
            //remove effect
            Destroy(this);
        }
	}
}
