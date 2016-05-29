using UnityEngine;
using System.Collections;

public class BossScript : EnemyBase{

    public AudioClip deathsound;

    public int baseDMG;


    public override void Start()
    {
        audioSource = GetComponent<AudioSource>();
        deathAudio = deathsound;


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
