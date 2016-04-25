using UnityEngine;
using System.Collections.Generic;

public class PathScript : MonoBehaviour {

    public bool coen;
    public List<Transform> wpList = new List<Transform>();
    public bool showGizmo = true;
    public Color gizmoColor = Color.blue;

    public List<Vector3> GetWaypointList() {
        List<Vector3> list = new List<Vector3>();
        for (int i = 0; i < wpList.Count; i++) list.Add(wpList[i].position);
        return list;
    }
    

    void OnDrawGizmos(){
        if (showGizmo)
        {
            Gizmos.color = gizmoColor;

            //~ if(Application.isPlaying){
            //~ for(int i=1; i<wpSectionList.Count; i++){
            //~ List<Vector3> subPathO=GetWPSectionPath(i-1);
            //~ List<Vector3> subPath=GetWPSectionPath(i);

            //~ //Debug.Log(i+"    "+wpSectionList[i].isPlatform+"    "+subPathO.Count+"   "+subPath.Count);

            //~ Gizmos.DrawLine(subPathO[subPathO.Count-1], subPath[0]);
            //~ for(int n=1; n<subPath.Count; n++){
            //~ Gizmos.DrawLine(subPath[n-1], subPath[n]);
            //~ }
            //~ }
            //~ }
            //~ else{
            for (int i = 1; i < wpList.Count; i++)
            {
                if (wpList[i - 1] != null && wpList[i] != null)
                    Gizmos.DrawLine(wpList[i - 1].position, wpList[i].position);
            }
            //~ }
        }
    }
}
