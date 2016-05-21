using UnityEngine;
using System.Collections;

public class EnemyMushroom : EnemyBase {

    public AudioClip deathsound;

	public override void Start () {
        audioSource = GetComponent<AudioSource>();
        deathAudio = deathsound;
    }

    void FixedUpdate(){
        Move();
    }
}
