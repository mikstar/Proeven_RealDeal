using UnityEngine;
using System.Collections;

public class OneshotParticle : MonoBehaviour {

    public ParticleSystem par;

	// Use this for initialization
	void Start () {
        //when obj is made, imediately start a set countdown for its destruction
        Invoke("killparticle", par.startLifetime + par.duration);
    }
    
    private void killparticle()
    {
        Destroy(gameObject);
    }
}
