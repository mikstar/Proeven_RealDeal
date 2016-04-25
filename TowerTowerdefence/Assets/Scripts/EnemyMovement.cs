using UnityEngine;
using System.Collections;

public class EnemyMovement : EnemyBase {

    private GameObject path;
    private Transform targetWaypoint;
    private int waypointIndex;

    void Awake() {
        path = GameObject.Find("Path1");
    }

    void GetNextWaypoint() {
        targetWaypoint = path.transform.GetChild(waypointIndex);
        waypointIndex++;
    }

    void ReachedGoal()
    {
        Destroy(gameObject);
    }

    void Update() {
        if (targetWaypoint == null) { 
            GetNextWaypoint();
            if (targetWaypoint == null) {
                ReachedGoal();
            }
        }

        Vector3 dir = targetWaypoint.position - gameObject.transform.position;
        float distThisFrame = moveSpeed * Time.deltaTime;

        if(dir.magnitude <= distThisFrame)
        {
            targetWaypoint = null;
        }

        transform.Translate(dir.normalized * distThisFrame, Space.World);
        Quaternion targetRotation = Quaternion.LookRotation(dir);
        this.transform.rotation = Quaternion.Lerp(this.transform.rotation, targetRotation, turnSpeed * Time.deltaTime);
    }
}
