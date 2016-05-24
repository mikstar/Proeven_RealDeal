using UnityEngine;
using System.Collections;

public class ObjectRotater : MonoBehaviour {

	public Vector3 rotation;
	public float speed;

	Transform cachedTF;

	void Start()
	{
		cachedTF = transform;
	}

	// Update is called once per frame
	void Update () 
	{
		cachedTF.Rotate( rotation * speed * Time.deltaTime );
	}
}
