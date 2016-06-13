using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    [Header("Speed Stats")]
    public float speed;                     //Movement speed of the enemy
    public float turnSpeed;                 //Turn speed of the enemy

    [HideInInspector]
    public ResourceManager rManager;        //Resource manager
    [HideInInspector]
    public AudioManager aManager;           //Audio manager
    [HideInInspector]
    public SpawnManager sManager;           //Spawn manager
    [HideInInspector]
    public GameObject path;                 //The path the enemy will walk on

    private Transform targetWaypoint;       //The next waypoint in the path
    private int waypointIndex;              
    private bool pathDone = false;          
    private int dmgz;                       //Damage enemy will do to player

    protected bool ableToMove = true;

    public virtual void Start()
    {
        
    }

    /// <summary>
    /// Moves the enemy along the path it has been given.
    /// </summary>
    protected void Move(int endDMG)
    {
        dmgz = endDMG;

        if (ableToMove)
        {
            //If the enemy has no waypoint, find the waypoint
            if (targetWaypoint == null)
            {
                GetNextWaypoint(dmgz);

                //If no waypoint is found and the path is not done yet
                if (targetWaypoint == null && !pathDone)
                {
                    ReachedGoal(dmgz);
                    return;
                }
            }
            else
            {
                //The direction for the enemy
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

    /// <summary>
    /// Get the next waypoint in the enemy path.
    /// </summary>
    private void GetNextWaypoint(int dmg)
    {
        //Check if there is a next waypoint
        if(waypointIndex < path.transform.childCount)
        { 
            targetWaypoint = path.transform.GetChild(waypointIndex);
            waypointIndex++;
        }
        //Else the path is done and the enemy has reached its destination
        else
        {
            targetWaypoint = null;
            ReachedGoal(dmg);
        }
    }

    /// <summary>
    /// Deals damage to player base and destroys enemy when it has reached the last waypoint.
    /// </summary>
    private void ReachedGoal(int dmg)
    {
        //Play audio for taking base damage
        aManager.PlayBaseDMG();

        //Do damage to base/player
        rManager.BaseTakeDMG(dmg);

        //Destroy enemy 
        pathDone = true;
        Destroy(gameObject);
    }
}
