using UnityEngine;
using System.Collections;

public class TurrentSlowArea : TowerBase{

    public float speedChange;
    public float effectDuration;

    protected override void fireTurrent()
    {

        audioSRS.Play();

        for (int i=0;i< targets.Count; i++)
        {
            if (targets[i].GetComponent<EnemyBase>().isDead == false)
            {
                if (targets[i].GetComponent<Debuff_Slow>() != null)
                {
                    targets[i].GetComponent<Debuff_Slow>().setStatsAndReset(effectDuration);
                }
                else
                {
                    Debuff_Slow newBuff = targets[i].AddComponent<Debuff_Slow>() as Debuff_Slow;
                    newBuff.setStatsAndStart(speedChange, effectDuration);
                }
            }
            else
            {
                targets.RemoveAt(i);
                i--;
            }
        }
    }
}
