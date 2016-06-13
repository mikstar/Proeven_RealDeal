using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TurrentLightning : TowerBase{

    //prefab to instantiate when fireing at an enemy
    public GameObject beamPrefab;
    //transfrom from which beams will originate when fireing
    public Transform firePoint;
    //List off all instantiate beams
    private List<LineRenderer> beams = new List<LineRenderer>();

    protected override void fireTurrent()
    {
        //check through all current targets
        for (int i=0;i<targets.Count; i++)
        {
            //check if target still exists
            if (targets[i].GetComponent<EnemyBase>().isDead == false)
            {
                //Apply damage to target
                targets[i].GetComponent<EnemyBase>().DamageEnemy(damage);
            }
            else
            {
                //if not, remove empty target
                targets.RemoveAt(i);
                i--;
            }
        }
        //play fireing audio if there's at least 1 target
        if(targets.Count > 0)
        {
            audioSRS.Play();
        }

        //check how many(if any) new beams are needed
        int beamsNeeded = targets.Count - beams.Count;
        for (int j=0;j<beamsNeeded; j++)
        {
            //instantiate any new beams that are needed
            beams.Add( (Instantiate(beamPrefab, transform.position, Quaternion.identity) as GameObject).GetComponent<LineRenderer>() );
        }
        //activate and move a beam for each target
        for(int h = 0; h < targets.Count; h++)
        {
            //Reset any non-active beam
            beams[h].gameObject.GetComponent<AutoFade>().reset();
            //set start of beam at the firePoint
            beams[h].SetPosition(0, firePoint.position);
            //set middle of beam above the point between the firePoint and the target, so it has a 'arch' effect
            beams[h].SetPosition(1, (transform.up - Vector3.Project(transform.up, targets[h].transform.position - firePoint.position)) + (((targets[h].transform.position - firePoint.position) / 2) + firePoint.position));
            //set end of beam at the targeted enemy
            beams[h].SetPosition(2, targets[h].transform.position);

        }
    }
}
