using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    public float speed;
    public float turnSpeed;

    public ResourceManager rManager;

    public GameObject path;

    private Transform targetWaypoint;
    private int waypointIndex;
    private bool pathDone = false;

    public bool ableToMove = true;

    public virtual void Start() {
        
    }

    public void Move(){
        if (ableToMove) {
            if (targetWaypoint == null)
            {
                GetNextWaypoint();
                if (targetWaypoint == null && !pathDone){
                    ReachedGoal();
                    return;
                }
            }

            Vector3 dir = targetWaypoint.position - gameObject.transform.position;
            float distThisFrame = speed * Time.deltaTime;

            if (dir.magnitude <= distThisFrame){
                targetWaypoint = null;
            }

            transform.Translate(dir.normalized * distThisFrame, Space.World);
            Quaternion targetRotation = Quaternion.LookRotation(dir);
            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, targetRotation, turnSpeed * Time.deltaTime);
        }
        else { 
            
        }
    }

    void GetNextWaypoint() {
        if(waypointIndex < path.transform.childCount) { 
            targetWaypoint = path.transform.GetChild(waypointIndex);
            waypointIndex++;
        }else{
            targetWaypoint = null;
            ReachedGoal();
        }
    }

    void ReachedGoal(){
        Destroy(gameObject);

        rManager.BaseTakeDMG();
        pathDone = true;
        
        //if (PlayerDB.Instance.health-- <= 1)
       // {
           // Debug.Log("lollipop");
        //}
    }
}
