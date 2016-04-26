using UnityEngine;
using System.Collections;

public class TurnAlighn : MonoBehaviour {
    
    public Transform alighObj;
    public bool invert;

    // Update is called once per frame
    void Update () {
        Vector3 newang = new Vector3(alighObj.localEulerAngles.y*2, 0, 0);
        if (invert)
        {
            newang.x = -newang.x;
        }
        transform.localEulerAngles = newang;
	}
}
