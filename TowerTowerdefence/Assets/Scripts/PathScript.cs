using UnityEngine;
using System.Collections.Generic;

public class PathScript : MonoBehaviour {

    public List<Transform> wpList = new List<Transform>();
    public bool showGizmo = true;
    public Color gizmoColor = Color.blue;

    public List<Vector3> GetWaypointList() {
        List<Vector3> list = new List<Vector3>();
        for (int i = 0; i < wpList.Count; i++) list.Add(wpList[i].position);
        return list;
    }
    
    void OnDrawGizmos(){
        if (showGizmo){
            Gizmos.color = gizmoColor;

            for (int i = 1; i < wpList.Count; i++){
                if (wpList[i - 1] != null && wpList[i] != null)
                    Gizmos.DrawLine(wpList[i - 1].position, wpList[i].position);
            }
        }
    }
}
