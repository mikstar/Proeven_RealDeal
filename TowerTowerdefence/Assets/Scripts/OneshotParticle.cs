using UnityEngine;
using System.Collections;

public class OneshotParticle : MonoBehaviour {

    public ParticleSystem par;

	// Use this for initialization
	void Start () {

        Invoke("killparticle", par.startLifetime + par.duration);
    }
    
    private void killparticle()
    {
        Destroy(gameObject);
    }
}
