using UnityEngine;
using System.Collections;

public class ResourceManager : MonoBehaviour {

    public void BaseTakeDMG() {
        PlayerDB.Instance.health--;
        Debug.Log(PlayerDB.Instance.health);
    }
}
