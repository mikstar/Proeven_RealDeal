using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TurrentLightning : TowerBase{

    //public float damage;
    //public float firerate;//shots per minute
    //public float range;

    //private GameObject[] targets;

    public GameObject beamPrefab;
    public Transform firePoint;
    
    private List<LineRenderer> beams = new List<LineRenderer>();

    protected override void fireTurrent()
    {
        for (int i=0;i<targets.Count; i++)
        {
            //check if target still exists
            if (targets[i].GetComponent<EnemyBase>().isDead == false)
            {
                //targets[i].GetComponent<EnemyBase>().DamageEnemy(damage);
            }
            else
            {
                targets.RemoveAt(i);
                i--;
            }
        }
        //check how many(if any) new beams are needed
        int beamsNeeded = targets.Count - beams.Count;
        for (int j=0;j<beamsNeeded; j++)
        {
            beams.Add( (Instantiate(beamPrefab, transform.position, Quaternion.identity) as GameObject).GetComponent<LineRenderer>() );
        }

        for(int h = 0; h < targets.Count; h++)
        {
            beams[h].gameObject.GetComponent<AutoFade>().reset();
            beams[h].SetPosition(0, firePoint.position);

            beams[h].SetPosition(1, (transform.up - Vector3.Project(transform.up, targets[h].transform.position - firePoint.position)) + (((targets[h].transform.position - firePoint.position) / 2) + firePoint.position));
            
            beams[h].SetPosition(2, targets[h].transform.position);

        }
    }
}
