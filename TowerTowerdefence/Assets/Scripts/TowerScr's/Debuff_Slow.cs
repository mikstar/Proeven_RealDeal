using UnityEngine;
using System.Collections;

public class Debuff_Slow : MonoBehaviour {

    private float timeLeft;
    private float fullSpd;
    private EnemyBase enmSrc;

    // Use this for initialization
    public void setStatsAndStart(float spdChnge, float duration)
    {
        timeLeft = duration;
        enmSrc = GetComponent<EnemyBase>();
        fullSpd = enmSrc.speed;
        enmSrc.speed = enmSrc.speed * spdChnge;

    }
    public void setStatsAndReset(float duration)
    {
        timeLeft = duration;
    }

    // Update is called once per frame
    void Update () {

        timeLeft -= Time.deltaTime;

        if (timeLeft < 0)
        {
            enmSrc.speed = fullSpd;
            Destroy(this);
        }
	}
}
