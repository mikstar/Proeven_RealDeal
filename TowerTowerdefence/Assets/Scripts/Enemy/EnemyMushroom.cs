using UnityEngine;
using System.Collections;

public class EnemyMushroom : EnemyBase {

    public AudioClip deathsound;

    private int baseDMG;
  

	public override void Start () {
        audioSource = GetComponent<AudioSource>();
        deathAudio = deathsound;

        baseDMG = 3;
    }

    void FixedUpdate(){
        Move(baseDMG);

        if (isDead)
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("Death"))
            {
                FadeOut();
            }
        }
    }
}
