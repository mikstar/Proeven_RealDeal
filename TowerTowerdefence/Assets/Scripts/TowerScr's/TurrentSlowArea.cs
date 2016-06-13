using UnityEngine;
using System.Collections;

public class TurrentSlowArea : TowerBase{
    //effect strenghth and duration of the towers slow effect
    public float speedChange;
    public float effectDuration;

    protected override void fireTurrent()
    {
        //play fire audio
        audioSRS.Play();

        //check through all targets
        for (int i=0;i< targets.Count; i++)
        {
            //check if target is live
            if (targets[i].GetComponent<EnemyBase>().isDead == false)
            {
                //check if there's already a slow effect on this enemy
                if (targets[i].GetComponent<Debuff_Slow>() != null)
                {
                    //refresh duration of existing effect
                    targets[i].GetComponent<Debuff_Slow>().setStatsAndReset(effectDuration);
                }
                //if there's no slow effect on this enemy
                else
                {
                    //apply new slow effect and set its stats 
                    Debuff_Slow newBuff = targets[i].AddComponent<Debuff_Slow>() as Debuff_Slow;
                    newBuff.setStatsAndStart(speedChange, effectDuration);
                }
            }
            else
            {
                //remove target if not alive 
                targets.RemoveAt(i);
                i--;
            }
        }
    }
}
