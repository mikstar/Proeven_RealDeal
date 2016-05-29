using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    public float speed;
    public float turnSpeed;

    public ResourceManager rManager;
    public AudioManager aManager;

    public GameObject path;

    private Transform targetWaypoint;
    private int waypointIndex;
    private bool pathDone = false;

    public bool ableToMove = true;

    private int dmgz;

    public virtual void Start() {
        
    }

    public void Move(int endDMG){
        dmgz = endDMG;

        if (ableToMove) {
            if (targetWaypoint == null)
            {
                GetNextWaypoint(dmgz);
                if (targetWaypoint == null && !pathDone)
                {
                    ReachedGoal(dmgz);
                    return;
                }
            }
            else {
                Vector3 dir = targetWaypoint.position - gameObject.transform.position;
                float distThisFrame = speed * Time.deltaTime;

                if (dir.magnitude <= distThisFrame)
                {
                    targetWaypoint = null;
                }

                transform.Translate(dir.normalized * distThisFrame, Space.World);
                Quaternion targetRotation = Quaternion.LookRotation(dir);
                this.transform.rotation = Quaternion.Lerp(this.transform.rotation, targetRotation, turnSpeed * Time.deltaTime);
            }  
        }
    }

    void GetNextWaypoint(int dmg) {
        if(waypointIndex < path.transform.childCount){ 
            targetWaypoint = path.transform.GetChild(waypointIndex);
            waypointIndex++;
        }else{
            targetWaypoint = null;
            ReachedGoal(dmg);
        }
    }

    void ReachedGoal(int dmg){
        aManager.PlayBaseDMG();

        rManager.BaseTakeDMG(dmg);
        pathDone = true;
        Destroy(gameObject);

        //if (PlayerDB.Instance.health-- <= 1)
        // {
        // Debug.Log("lollipop");
        //}
    }
}
